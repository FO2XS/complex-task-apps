using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DbHendler
{
	public class DbList<T>
		: ICollection<T>
		where T : new()
	{
		public DbList(NpgsqlConnection connection)
		{
			Connection = connection
						 ?? throw new ArgumentNullException(nameof(connection));

			TableName = this
				.GetType()
				.GetGenericArguments()[0];

			Constructor = TableName.GetConstructors().FirstOrDefault(x => x.GetParameters().Count() == 0)
				?? throw new Exception("Тип данных не содержит пустого конструктора");
			try
			{
				ListProp = new List<String>();
				foreach (var item in TableName.GetProperties())
					ListProp.Add(item.Name);

				GetData();
			}
			catch (SqlException e)
			{
				throw new Exception("Ошибка в конструкторе класса DbList!\nОписание: " + e.Message);
			}
			catch (Exception e)
			{
				throw new Exception("Неизвестная ошибка в конструкторе класса DbList!\nОписание: " + e.Message);
			}
		}

		private Type TableName { get; }
		private List<String> ListProp { get; }
		private ConstructorInfo Constructor { get; }


		private List<T> ListItem { get; set; } = new List<T>();
		public int Count => ListItem.Count;

		public bool IsReadOnly => false;

		public NpgsqlConnection Connection { get; }

		public void GetData()
		{
			try
			{
				Connection.Open();

				var strSql = $"SELECT * FROM {TableName.Name}";
				var cmd = new NpgsqlCommand(strSql, Connection);
				var read = cmd.ExecuteReader();


				while (read.Read())
				{
					Object ob = Constructor.Invoke(null);

					foreach (var item in TableName.GetProperties())
                    {
						var d = read[item.Name];
						String s = d?.ToString();
						if(d is System.DBNull)
							item.SetValue(ob, null);
						else
							item.SetValue(ob, d);
					}

					ListItem.Add((T)ob);
				}
			}
			catch (Exception e)
			{
				throw new Exception("Не удалось прочитать данные из таблицы\nОписание: " + e.Message);
			}
            finally
            {
				Connection.Close();
            }
		}

		public void Add(T item)
		{
            try
            {
				var values = "";
				var it = "";

				foreach (var items in TableName.GetProperties())
                {
					var val = items.GetValue(item);

					if (items.Name.ToLower() == "id" || val is null)
						continue;

					if (val is String)
						values += $" '{val}', ";

					else if (val is DateTime? || val is DateTime)
						values += $" '{(DateTime)val}', ";
					
					else
						values += $" {val}, ";

					it += $"{items.Name}, ";
				}

				values = values.Remove(values.Length - 2, 2);
				it = it.Remove(it.Length - 2, 2);

				var strSql = $"INSERT INTO {TableName.Name}({it}) VALUES ({values})";
				MessageBox.Show(strSql);
				Connection.Open();

				var cmd = new NpgsqlCommand(strSql, Connection);
				
				if (cmd.ExecuteNonQuery() != 1)
					throw new Exception("Не удалось сделать вставку!");
			}
            catch (Exception e)
            {
				throw new Exception("Не удалось выполнить вставку по следующей причине!\nОписание: " + e.Message);
			}
			finally
			{
				Connection.Close();
			}
		}

		public bool Remove(T item)
		{
			Boolean b = false;

			try
			{
				var values = "";

				foreach (var items in TableName.GetProperties())
				{
					var val = items.GetValue(item);

					if (val is String || val is DateTime)
						values += $" {items.Name} = '{val}' AND";

					else
						values += $" {items.Name} = {val} AND";
				}

				values = values.Remove(values.Length - 3, 3);

				Connection.Open();

				var strSql = $"DELETE {TableName.Name} WHERE ({values})";
				var cmd = new NpgsqlCommand(strSql, Connection);

				if (cmd.ExecuteNonQuery() != 1)
					throw new Exception("Не удалось удалить строку!");

				b = true;
			}
			catch (Exception e)
			{
				/// throw new Exception("Не удалось удалить строку по следующей причине!\nОписание: " + e.Message);
				b = false;
			}
			finally
			{
				Connection.Close();
			}

			return b;
		}


		public bool Contains(T item) 
			=> ListItem.Contains(item);


		public IEnumerator<T> GetEnumerator()
			=> ListItem.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator()
			=> ListItem.GetEnumerator();

        public void CopyTo(T[] array, int arrayIndex)
        {
            ((ICollection<T>)ListItem).CopyTo(array, arrayIndex);
        }

        public void Clear()
        {
            ((ICollection<T>)ListItem).Clear();
        }
    }
}
