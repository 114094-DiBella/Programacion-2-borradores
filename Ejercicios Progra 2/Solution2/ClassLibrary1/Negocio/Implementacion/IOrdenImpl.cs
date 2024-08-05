using ClassLibrary1.Data.Dao.Interface;
using ClassLibrary1.Models;
using ClassLibrary1.Negocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Negocio.Implementacion
{
    public class IOrdenImpl : IOrden
    {
        private readonly IDaoOrden _daoOrden;

        public IOrdenImpl(IDaoOrden dao)
        {
            _daoOrden = dao;
        }
        public bool CrearDetalle(DetalleOrden detalle)
        {
            if(detalle.Orden == null)
            {
                throw new Exception("Debe cargar una orden");
            }
            if(detalle.Cantidad == null)
            {
                throw new Exception("Debe cargar una cantidad");
            }
            if(detalle.Material == null)
            {
                throw new Exception("Debe cargar un material");
            }
           
            return _daoOrden.CrearDetalle(detalle);
        }

        public bool CrearOrden(OrdenRetiro orden)
        {
            return _daoOrden.CrearOrden(orden);
        }

        public List<Material> ObtenerMateriales()
        {
            return _daoOrden.GetAllMaterials();
        }
    }
}
