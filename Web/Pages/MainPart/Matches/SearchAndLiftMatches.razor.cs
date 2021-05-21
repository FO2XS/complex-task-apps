﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Test.Data.ModalEntity;

namespace Test.Pages.MainPart.Matches
{
    public partial class SearchAndLiftMatches
    {
        [Parameter]
        public List<Event> Events { get; set; }

        [Parameter]
        public EventCallback<List<Event>> LeafEventsCallback { get; set; }

        [Parameter] public int Step { get; set; }

        private int step = 10;
        private int indexStart = 0;

        /// <summary>
        /// Листает отображаемые события из общего списка
        /// </summary>
        /// <param name="side">true - вперед по списку, false - назад по списку</param>
        private async void ChangeDisplayEvents (bool side)
        {
            var sideStep = side ? step : -step;

            indexStart += sideStep;

            if (indexStart >= Events.Count - step)
            {
                indexStart = Events.Count - step;
            }
            if (indexStart < 0)
            {
                indexStart = 0;
            }

            var displayEvents = step >= Events.Count ? Events.GetRange(0, Events.Count).ToList() : Events.GetRange(indexStart, step).ToList();
            await LeafEventsCallback.InvokeAsync(displayEvents);
        }
    }
}