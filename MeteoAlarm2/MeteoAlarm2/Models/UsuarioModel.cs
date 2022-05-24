using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MeteoAlarm2.Models
{
    public class UsuarioModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }




        

        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }

        private string magnitud;

        public string Magnitud 
        {
            get { return magnitud; }
            set { magnitud = value;
                OnPropertyChanged();
            }

        }

        private string distancia;

        public string Distancia
        {
            get { return distancia; }
            set { distancia = value;
                OnPropertyChanged();
            }
        }

        private string municipio;

        public string Municipio
        {
            get { return municipio; }
            set { municipio = value;
                OnPropertyChanged();
            }
        }

        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set
            {
                fecha = value;
                OnPropertyChanged();
            }
        }









    }
}
