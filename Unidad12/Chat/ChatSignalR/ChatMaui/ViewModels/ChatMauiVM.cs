using ChatMaui.ViewModels.utils;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.ApplicationModel;

namespace ChatMaui.ViewModels
{
    public class ChatMauiVM: Notify
    {
        #region atributos
        private readonly HubConnection connection;
        private clsMensajeUsuario mensajeUsuario;
        private DelegateCommand enviarCommand;

        private ObservableCollection<clsMensajeUsuario> listaMensajes;

        private string usuario;
        private string mensaje;
        #endregion

        #region propiedades
        public ObservableCollection<clsMensajeUsuario> ListaMensajes 
        {
            get { return  listaMensajes; }
            set { listaMensajes = value;}
        }
        public string Usuario 
        {
            get { return usuario; }
            set { usuario = value; enviarCommand.RaiseCanExecuteChanged(); }
        }
        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; enviarCommand.RaiseCanExecuteChanged(); }
        }

        public DelegateCommand EnviarCommand
        {
            get { return enviarCommand; }
        }
        #endregion

        #region constructor
        public ChatMauiVM()
        {
            enviarCommand = new DelegateCommand(enviarExecute, enviarCanExecute);
            listaMensajes = new ObservableCollection<clsMensajeUsuario>();
            connection = new HubConnectionBuilder().WithUrl("http://localhost:5250/chathub").Build();

            connection.On<clsMensajeUsuario>("ReceiveMessage", (message) =>
            {
                MainThread.InvokeOnMainThreadAsync(() =>
                {
                    listaMensajes.Add(message);
                    NotifyPropertyChanged("ListaMensajes");
                });
            });

            conexion();
            
        }
        #endregion

        private async void conexion()
        {
            await connection.StartAsync();
        }

        #region Commands
        public async void enviarExecute()
        {
            mensajeUsuario = new clsMensajeUsuario(usuario, mensaje);
            await connection.InvokeCoreAsync("SendMessage", args: new[] { mensajeUsuario });
            usuario = String.Empty;
            mensaje = String.Empty;
            NotifyPropertyChanged("Usuario");
            NotifyPropertyChanged("Mensaje");
        }

        public bool enviarCanExecute()
        {
            bool canExecute = true;
            if (String.IsNullOrEmpty(mensaje) || String.IsNullOrEmpty(usuario))
            {
                canExecute = false;
            }
            return canExecute;
        }
        #endregion
    }
}
