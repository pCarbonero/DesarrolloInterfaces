using ApiPersonasMaui.Viewmodels.Utils;
using DAL;
using Entidades;
using MauiPokemon.ViewModels.Utilidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public int IdDepartamento
        {
            get { return idDepartamento; }
            set { idDepartamento = value; }
        }

        public clsDepartamento DepartamentoSeleccionado
        {
            get { return departamentoSeleccionado; }
            set { departamentoSeleccionado = value; }
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
                && !String.IsNullOrEmpty(Telefono) && Direccion != null && departamentoSeleccionado.Id != 0)
            {
                canExecute = true;
            }

            return canExecute;
        }

        private async void addPersonaExecute()
        {  
            try
            {
                idDepartamento = departamentoSeleccionado.Id;
                persona = new clsPersona(nombre, apellidos, telefono, direccion, foto, fechaNacimiento, idDepartamento);

                await Services.addPersona(persona);
                await Shell.Current.GoToAsync("///MainPage");
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
