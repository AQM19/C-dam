<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT2E8
{
    public class Cita
    {

        private static int citaid = 0;
        private DateTime fecha;
        private int personaid;

        public Cita() { }
        public Cita(DateTime fecha, int personaid)
        {
            ++citaid;
            this.fecha = fecha;
            this.personaid = personaid;
        }
        public int Citaid
        {
            get
            {
                return citaid;
            }
            set
            {
                citaid = value;
            }
        }
        public DateTime Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
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
    public class Cita
    {

        private static int citaid = 0;
        private DateTime fecha;
        private int personaid;

        public Cita() { }
        public Cita(DateTime fecha, int personaid)
        {
            ++citaid;
            this.fecha = fecha;
            this.personaid = personaid;
        }
        public int Citaid
        {
            get
            {
                return citaid;
            }
            set
            {
                citaid = value;
            }
        }
        public DateTime Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
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
