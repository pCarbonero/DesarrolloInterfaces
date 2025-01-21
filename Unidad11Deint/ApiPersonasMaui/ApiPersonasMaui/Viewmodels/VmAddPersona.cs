using ApiPersonasMaui.Viewmodels.Utils;
using DAL;
using Entidades;
using MauiPokemon.ViewModels.Utilidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ApiPersonasMaui.Viewmodels
{
    public class VmAddPersona: Notify
    {
        #region atributos
        private clsPersona persona;
        private ObservableCollection<clsDepartamento> listaDepartamentos;

        private string nombre;
        private string apellidos;
        private string telefono;
        private string direccion;
        private string foto;
        private DateTime fechaNacimiento;
        private int idDepartamento;

        private clsDepartamento departamentoSeleccionado;

        private DelegateCommand addPersonaCommand;
        #endregion

        #region propiedades
        public ObservableCollection<clsDepartamento> ListaDepartamentos
        {
            get { return listaDepartamentos; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; addPersonaCommand.RaiseCanExecuteChanged(); }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; addPersonaCommand.RaiseCanExecuteChanged(); }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; addPersonaCommand.RaiseCanExecuteChanged(); }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; addPersonaCommand.RaiseCanExecuteChanged(); }
        }

        public string Foto
        {
            get { return foto; }
            set { foto = value; addPersonaCommand.RaiseCanExecuteChanged(); }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; addPersonaCommand.RaiseCanExecuteChanged(); NotifyPropertyChanged("FechaNacimiento"); }
        }
        public int IdDepartamento
        {
            get { return idDepartamento; }
            set { idDepartamento = value; addPersonaCommand.RaiseCanExecuteChanged(); }
        }

        public clsDepartamento DepartamentoSeleccionado
        {
            get { return departamentoSeleccionado; }
            set { departamentoSeleccionado = value; addPersonaCommand.RaiseCanExecuteChanged(); }
        }

        public DelegateCommand AddPersonaCommand
        {
            get { return addPersonaCommand; }
        }
        #endregion

        #region Constructores
        public VmAddPersona()
        {
            addPersonaCommand = new DelegateCommand(addPersonaExecute, addPersonaCanExecute);
            cargarListaDepartamentos();
        }
        #endregion

        #region Command
        private bool addPersonaCanExecute()
        {
            bool canExecute = false;

            if (!String.IsNullOrEmpty(Nombre) && !String.IsNullOrEmpty(Apellidos) && !String.IsNullOrEmpty(Foto)
                && !String.IsNullOrEmpty(Telefono) && Direccion != null && (departamentoSeleccionado != null && departamentoSeleccionado.Id != 0))
            {
                canExecute = true;
            }

            return canExecute;
        }

        private async void addPersonaExecute()
        {
            HttpStatusCode respuesta;
            try
            {
                idDepartamento = departamentoSeleccionado.Id;
                persona = new clsPersona(nombre, apellidos, telefono, direccion, foto, fechaNacimiento, idDepartamento);

                respuesta = await Services.addPersona(persona);

                if (respuesta == HttpStatusCode.OK)
                {
                    await Shell.Current.GoToAsync("///MainPage");
                }
                else if (respuesta == HttpStatusCode.BadRequest)
                {
                    await Application.Current.MainPage.DisplayAlert("Error 400 Bad Request", "Intentalo más tarde.", "OK");
                }
                
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Intentalo más tarde.", "OK");
            }
        }
        #endregion

        #region metodos

        private async void cargarListaDepartamentos()
        {
            listaDepartamentos = new ObservableCollection<clsDepartamento>(await Services.getListaDepartamentos());
            NotifyPropertyChanged("ListaDepartamentos");
        }

        #endregion
    }
}
