<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT2E3
{
    internal class Calculadora
    {
        private float _cache;
        private float _visor;
        private OperacionEnum _operacion;

        /// <summary>
        /// Almacenar el valor indicado por el usuario
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Una propiedad de tipo float denominada Memoria para almacenar un valor indicado por el usuario.
        /// </remarks>
        public float Memoria {
            get;
            set;
        }

        /// <summary>
        /// Propiedad de Operacion donde devuelve el valor de un Enum.
        /// </summary>
        /// <remarks>
        /// Al establecerse el valor si _operacion tiene el valor de SinOperacion se
        /// asignara a _cache el valor de _visor, Si no se cumple el valor se llamara a
        /// Calcular() y se asignara a _cache el valor de _visor.
        /// </remarks>
        public OperacionEnum Operacion { 
            get {
                return _operacion;
            }
            set
            {
                 if(_operacion != OperacionEnum.SinOperacion)
                {
                    Calcular();
                }
                _operacion = value;
                _cache = _visor;
            }
        }

        /// <summary>
        /// Propiedad Visor de tipo float que de respaldo al campo _visor
        /// </summary>
        /// <remarks>
        /// Una propiedad de tipo float que de respaldo al campo _visor
        /// </remarks>
        public float Visor
        {
            get
            {
                return _visor;
            }
            set
            {
                _visor = value;
            }
        }

        public void Calcular()
        {
            switch(Operacion)
            {
                case OperacionEnum.SinOperacion:
                    {
                        return;
                    }
                case OperacionEnum.Suma: {
                        _visor = _cache + _visor;
                    }
                    break;
                case OperacionEnum.Resta: {
                        _visor = _cache - _visor;
                    }
                    break;
                case OperacionEnum.Multiplicacion: {
                        _visor = _cache * _visor;
                    }
                    break;
                case OperacionEnum.Division: {
                        _visor = _cache / _visor;
                    }
                    break;
            }

            _operacion = OperacionEnum.SinOperacion;
        }

        public void Borrar()
        {
            _cache = 0;
            _operacion = OperacionEnum.SinOperacion;
        }

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT2E3
{
    internal class Calculadora
    {
        private float _cache;
        private float _visor;
        private OperacionEnum _operacion;

        /// <summary>
        /// Almacenar el valor indicado por el usuario
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Una propiedad de tipo float denominada Memoria para almacenar un valor indicado por el usuario.
        /// </remarks>
        public float Memoria {
            get;
            set;
        }

        /// <summary>
        /// Propiedad de Operacion donde devuelve el valor de un Enum.
        /// </summary>
        /// <remarks>
        /// Al establecerse el valor si _operacion tiene el valor de SinOperacion se
        /// asignara a _cache el valor de _visor, Si no se cumple el valor se llamara a
        /// Calcular() y se asignara a _cache el valor de _visor.
        /// </remarks>
        public OperacionEnum Operacion { 
            get {
                return _operacion;
            }
            set
            {
                 if(_operacion != OperacionEnum.SinOperacion)
                {
                    Calcular();
                }
                _operacion = value;
                _cache = _visor;
            }
        }

        /// <summary>
        /// Propiedad Visor de tipo float que de respaldo al campo _visor
        /// </summary>
        /// <remarks>
        /// Una propiedad de tipo float que de respaldo al campo _visor
        /// </remarks>
        public float Visor
        {
            get
            {
                return _visor;
            }
            set
            {
                _visor = value;
            }
        }

        public void Calcular()
        {
            switch(Operacion)
            {
                case OperacionEnum.SinOperacion:
                    {
                        return;
                    }
                case OperacionEnum.Suma: {
                        _visor = _cache + _visor;
                    }
                    break;
                case OperacionEnum.Resta: {
                        _visor = _cache - _visor;
                    }
                    break;
                case OperacionEnum.Multiplicacion: {
                        _visor = _cache * _visor;
                    }
                    break;
                case OperacionEnum.Division: {
                        _visor = _cache / _visor;
                    }
                    break;
            }

            _operacion = OperacionEnum.SinOperacion;
        }

        public void Borrar()
        {
            _cache = 0;
            _operacion = OperacionEnum.SinOperacion;
        }

    }
}
>>>>>>> 7cd2f28877c92113fce0063e557bb9060cc28b21
