<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT2E5
{
    internal class Documento
    {
        private string _path;
        private string _texto;

        public Documento() {
            this._texto = string.Empty;
        }
        public Documento(string path)
        {
            this._path = path;
            this._texto = System.IO.File.ReadAllText(this._path);
        }

        public string Texto {
            get
            {
                return this._texto;
            } 
        }
        public string Ruta { 
            get
            {
                return this._path;
            }
        }

        public void Guardar()
        {
            System.IO.File.WriteAllText(this._path, this._texto);
        }

        public void GuardarComo(string textoNuevo, string rutaNueva)
        {
            System.IO.File.WriteAllText(rutaNueva, textoNuevo);
        }

        public bool EstaModificado(string textoNuevo)
        {
            return textoNuevo.Equals(_texto);
        }

        public void EscribirTexto(string nuevoTexto)
        {
            this._texto = nuevoTexto;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT2E5
{
    internal class Documento
    {
        private string _path;
        private string _texto;

        public Documento() {
            this._texto = string.Empty;
        }
        public Documento(string path)
        {
            this._path = path;
            this._texto = System.IO.File.ReadAllText(this._path);
        }

        public string Texto {
            get
            {
                return this._texto;
            } 
        }
        public string Ruta { 
            get
            {
                return this._path;
            }
        }

        public void Guardar()
        {
            System.IO.File.WriteAllText(this._path, this._texto);
        }

        public void GuardarComo(string textoNuevo, string rutaNueva)
        {
            System.IO.File.WriteAllText(rutaNueva, textoNuevo);
        }

        public bool EstaModificado(string textoNuevo)
        {
            return textoNuevo.Equals(_texto);
        }

        public void EscribirTexto(string nuevoTexto)
        {
            this._texto = nuevoTexto;
        }
    }
}
>>>>>>> 7cd2f28877c92113fce0063e557bb9060cc28b21
