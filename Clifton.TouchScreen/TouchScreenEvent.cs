using System;
using System.Collections.Generic;
using System.Text;

namespace Clifton.TouchScreen {
    public abstract class TouchScreenEvent {
        public string DisplayName { get; set; }

        public string Description { get; set; }

        public TouchScreenEvent(string displayName, string description) {
            DisplayName = displayName;
            Description = description;
        }
    }
}