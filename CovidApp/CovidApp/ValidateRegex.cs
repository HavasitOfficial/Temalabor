using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace CovidApp
{
    class ValidateRegex
    {
        public async void validateNameAndEmail(string name, string email)
        {
            if (!Regex.Match(name, "^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$").Success)
            {
                var messageDialog = new MessageDialog("Invalid name");
                messageDialog.DefaultCommandIndex = 0;
                messageDialog.CancelCommandIndex = 1;
                await messageDialog.ShowAsync();
            }
            if (!Regex.Match(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success)
            {

                var messageDialog = new MessageDialog("Invalid email address");
                messageDialog.DefaultCommandIndex = 0;
                messageDialog.CancelCommandIndex = 1;
                await messageDialog.ShowAsync();
            }
            return;
        }
    }
}
