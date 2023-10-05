<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UT2E8
{
    public class Clinica
    {
        private static List<Persona> personas;
        private static List<Informe> informes;
        private static List<Cita> citas;
        private static int sigPersonaId = 0;
        private static int sigCitaId = 0;
        static Clinica()
        {
            Clinica.personas = new List<Persona>();
            Clinica.informes = new List<Informe>();
            Clinica.citas = new List<Cita>();
        }
        private int SiguientePersonaId()
        {
            return ++sigPersonaId;
        }
        private int SiguienteCitaId()
        {
            return ++sigCitaId;
        }
        public Persona[] ObtenerPersonas()
        {
            return personas.ToArray();
        }
        public Persona BuscarPersona(int personaId)
        {
            return personas.FirstOrDefault(x => x.Personaid == personaId);
        }
        public void CrearPersona(Persona persona)
        {
            persona.Personaid = SiguientePersonaId();
            Informe info = new Informe(persona.Personaid);

            personas.Add(persona);
            informes.Add(info);

        }
        public void BorrarPersona(int personaId)
        {
            Persona p = personas.FirstOrDefault(x => x.Personaid == personaId);

            if(p != null)
            {
                List<Informe> informesdepersona = informes.Where(x => x.Personaid == personaId).ToList();
                List<Cita> citasdepersona = citas.Where(x => x.Personaid == personaId).ToList();

                if(informesdepersona.Count > 0)
                {
                    foreach(Informe i in informesdepersona)
                    {
                        BorrarInforme(i.Personaid);
                    }
                }
                if(citasdepersona.Count > 0)
                {
                    foreach(Cita c in citasdepersona)
                    {
                        BorrarCita(c.Citaid);
                    }
                }

                personas.Remove(p);
            }
        }
        public Informe BuscarInforme(int personaId)
        {
            return informes.FirstOrDefault(x => x.Personaid == personaId);
        }
        private void CrearInforme(Informe informe)
        {
            if(informe != null)
            {
                informes.Add(informe);
            }
        }
        private void BorrarInforme(int personaId)
        {
            Informe info = informes.FirstOrDefault(x => x.Personaid!= personaId);
            if(info != null)
            {
                informes.Remove(info);
            }
        }
        public Cita[] BuscarCitas(int personaId)
        {
            return citas.Where(x => x.Personaid == personaId).ToArray();
        }
        public Cita BuscarCita(int citaId)
        {
            return citas.FirstOrDefault(x => x.Citaid == citaId);
        }
        public void CrearCita(Cita cita)
        {
            if(cita != null)
            {
                citas.Add(cita);
            }
        }
        public void BorrarCita(int citaId)
        {
            Cita c = citas.FirstOrDefault(x => x.Citaid == citaId);

            if(c != null)
            {
                citas.Remove(c);
            }
        }
    }

}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UT2E8
{
    public class Clinica
    {
        private static List<Persona> personas;
        private static List<Informe> informes;
        private static List<Cita> citas;
        private static int sigPersonaId = 0;
        private static int sigCitaId = 0;
        static Clinica()
        {
            Clinica.personas = new List<Persona>();
            Clinica.informes = new List<Informe>();
            Clinica.citas = new List<Cita>();
        }
        private int SiguientePersonaId()
        {
            return ++sigPersonaId;
        }
        private int SiguienteCitaId()
        {
            return ++sigCitaId;
        }
        public Persona[] ObtenerPersonas()
        {
            return personas.ToArray();
        }
        public Persona BuscarPersona(int personaId)
        {
            return personas.FirstOrDefault(x => x.Personaid == personaId);
        }
        public void CrearPersona(Persona persona)
        {
            persona.Personaid = SiguientePersonaId();
            Informe info = new Informe(persona.Personaid);

            personas.Add(persona);
            informes.Add(info);

        }
        public void BorrarPersona(int personaId)
        {
            Persona p = personas.FirstOrDefault(x => x.Personaid == personaId);

            if(p != null)
            {
                List<Informe> informesdepersona = informes.Where(x => x.Personaid == personaId).ToList();
                List<Cita> citasdepersona = citas.Where(x => x.Personaid == personaId).ToList();

                if(informesdepersona.Count > 0)
                {
                    foreach(Informe i in informesdepersona)
                    {
                        BorrarInforme(i.Personaid);
                    }
                }
                if(citasdepersona.Count > 0)
                {
                    foreach(Cita c in citasdepersona)
                    {
                        BorrarCita(c.Citaid);
                    }
                }

                personas.Remove(p);
            }
        }
        public Informe BuscarInforme(int personaId)
        {
            return informes.FirstOrDefault(x => x.Personaid == personaId);
        }
        private void CrearInforme(Informe informe)
        {
            if(informe != null)
            {
                informes.Add(informe);
            }
        }
        private void BorrarInforme(int personaId)
        {
            Informe info = informes.FirstOrDefault(x => x.Personaid!= personaId);
            if(info != null)
            {
                informes.Remove(info);
            }
        }
        public Cita[] BuscarCitas(int personaId)
        {
            return citas.Where(x => x.Personaid == personaId).ToArray();
        }
        public Cita BuscarCita(int citaId)
        {
            return citas.FirstOrDefault(x => x.Citaid == citaId);
        }
        public void CrearCita(Cita cita)
        {
            if(cita != null)
            {
                citas.Add(cita);
            }
        }
        public void BorrarCita(int citaId)
        {
            Cita c = citas.FirstOrDefault(x => x.Citaid == citaId);

            if(c != null)
            {
                citas.Remove(c);
            }
        }
    }

}
>>>>>>> 7cd2f28877c92113fce0063e557bb9060cc28b21
