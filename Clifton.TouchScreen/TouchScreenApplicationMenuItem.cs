using System;
using System.Collections.Generic;
using System.Text;

namespace Clifton.TouchScreen {
    public enum TouchScreenApplicationMenuAction {
        Null,
        Pop,
        About,
        CustomAction
    }

    public sealed class TouchScreenApplicationMenuItem {
        //private ITouchScreenApplicationScreen pushedScreen = null;

        public TouchScreenApplicationMenuAction Action { get; private set; }
        public EventHandler CustomEventHandler { get; private set; }
        public string Name { get; private set; }
        public int Order { get; private set; }

        internal TouchScreenApplicationMenuItem(string name, int order, TouchScreenApplicationMenuAction action) {
            Name = name;
            Order = order;
            Action = action;
        }

        internal TouchScreenApplicationMenuItem(string name, int order, EventHandler customEventHandler) {
            Name = name;
            Order = order;
            Action = TouchScreenApplicationMenuAction.CustomAction;
            CustomEventHandler = customEventHandler;
        }
    }
}