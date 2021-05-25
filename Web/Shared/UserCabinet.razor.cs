using Test.Data.ModalEntity;
using Microsoft.AspNetCore.Components;

namespace Test.Shared
{
    public partial class UserCabinet
    {
        [CascadingParameter]
        public User User { get; set; }
        
    }
}
