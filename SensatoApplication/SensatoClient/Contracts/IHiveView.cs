﻿namespace SensatoClient.Contracts
{
    using MetroFramework.Controls;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public interface IHiveView : IView
    {
        event EventHandler LogoutClick;

        event EventHandler HiveButtonClick;

        event EventHandler AddHiveClick;

        event EventHandler RenameHiveClick;

        event EventHandler RemoveHiveClick;

        event EventHandler FrameClick;

        TableLayoutPanel HivesTable { get; }

        MetroPanel HiveControls { get; }

        bool IsEnabled { get; set; }

        void SubscibeHiveButtons(IEnumerable<Control> buttonsToSubscribe);

        void ResetHiveView();

    }
}
