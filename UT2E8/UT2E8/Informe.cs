<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT2E8
{
    public class Informe
    {
        private string alergias;
        private DateTime nacimiento;
        private string observaciones;
        private int personaid;

        public Informe(int personaid) {
            this.personaid = personaid;
        }
        public Informe(string alergias, DateTime nacimiento, string observaciones, int personaid)
        {
            this.alergias = alergias;
            this.nacimiento = nacimiento;
            this.observaciones = observaciones;
            this.personaid = personaid;
        }
        public string Alergias
        {
            get
            {
                return alergias;
            }
            set
            {
                alergias = value;
            }
        }
        public DateTime Nacimiento
        {
            get
            {
                return nacimiento;
            }
            set
            {
                nacimiento = value;
            }
        }
        public string Observaciones
        {
            get
            {
                return observaciones;
            }
            set
            {
                observaciones = value;
            }
        }
        public int Personaid
        {
            get
            {
                return personaid;
            }
            set
            {
                personaid = value;
            }
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT2E8
{
    public class Informe
    {
        private string alergias;
        private DateTime nacimiento;
        private string observaciones;
        private int personaid;

        public Informe(int personaid) {
            this.personaid = personaid;
        }
        public Informe(string alergias, DateTime nacimiento, string observaciones, int personaid)
        {
            this.alergias = alergias;
            this.nacimiento = nacimiento;
            this.observaciones = observaciones;
            this.personaid = personaid;
        }
        public string Alergias
        {
            get
            {
                return alergias;
            }
            set
            {
                alergias = value;
            }
        }
        public DateTime Nacimiento
        {
            get
            {
                return nacimiento;
            }
            set
            {
                nacimiento = value;
            }
        }
        public string Observaciones
        {
            get
            {
                return observaciones;
            }
            set
            {
                observaciones = value;
            }
        }
        public int Personaid
        {
            get
            {
                return personaid;
            }
            set
            {
                personaid = value;
            }
        }
    }
}
>>>>>>> 7cd2f28877c92113fce0063e557bb9060cc28b21
