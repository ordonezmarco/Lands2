

namespace Lands2.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Text;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Xamarin.Forms;

    class LoginViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Attirbutes
        private string email;
        private string password;
        private bool isRunning;
        private bool isEnable;
        #endregion

        #region Properties
        public string Email
        {
            get;
            set;
        }
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                if(this.password != value)
                {
                    this.password = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Password)));
                }
            }
        }
        public bool IsRunning
        {
            get
            {
                return this.isRunning;
            }
            set
            {
                if (this.isRunning != value)
                {
                    this.isRunning = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.IsRunning)));
                }
            }
        }
        public bool IsRemembered
        {
            get;
            set;
        }
        public bool IsEnable
        {
            get
            {
                return this.isEnable;
            }
            set
            {
                if (this.isEnable != value)
                {
                    this.isEnable = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.IsEnable)));
                }
            }
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
            this.isEnable = true;
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty( this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Your must enter an email.",
                    "Accept");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Your must enter a password.",
                    "Accept");
                return;
            }

            this.IsRunning = true;
            this.IsEnable = false;

            if (this.Email != "ordonez.marcos21@gmail.com" || this.Password != "123456")
            {
                this.IsRunning = false;
                this.IsEnable = true;

                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email or password incorrect.",
                    "Accept");
                this.Password = string.Empty;

                return;
            }

            this.IsRunning = false;
            this.IsEnable = true;

            await Application.Current.MainPage.DisplayAlert(
                    "Ok",
                    "Login Succesful.",
                    "Accept");

        }
        public ICommand RegisterCommand
        {
            get;
            set;
        }
        #endregion
    }
}
