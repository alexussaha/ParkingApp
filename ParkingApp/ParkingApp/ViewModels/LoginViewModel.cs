using Newtonsoft.Json;
using ParkingApp.Services;
using ParkingApp.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Xamarin.Forms;

namespace ParkingApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        private string _userName;
        private string _passWord;
        private string _text;
        LoginPassword user = new LoginPassword();

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        public string UserName
        {
            get => _userName;
            set => SetProperty(ref _userName, value);
        }

        public string PassWord
        {
            get => _passWord;
            set => SetProperty(ref _passWord, value);
        }

        public string Error
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }


        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            user.login = UserName;
            user.password = PassWord;
            if (user.login != "" && user.password != "" && user.password != "Пароль" && user.login != "Имя пользователя")
            {
                //string logPass = JsonConvert.SerializeObject(user);
                string logPass = "{\n\"username\": \""+ UserName + "\",\n\"password\": \"" + PassWord + "\"\n}";
                string answer = PostQue.POST("https://7bcc592c4736.ngrok.io" + "/api/v1/login/", logPass);//PUT YOUR API HERE
                if (WorkWithJson.IsValidJson(answer))
                {
                    ReceivedData.taken = JsonConvert.DeserializeObject<Token>(answer);
                    await Shell.Current.GoToAsync(nameof(ServiceChoosePage));

                }
                else
                {
                    Error = "Неверный логин или пароль";
                }
               
            }
            
            
        }
    }
}
