namespace WpfApp1.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ShipmentObject
    {
        public int Id { get; set; }

        public int id_shipment { get; set; }

        public int? id_cloht { get; set; }

        public int? CountCloht { get; set; }

        public int? id_furniture { get; set; }

        public int? CountFurniture { get; set; }

        public virtual Cloht Cloht { get; set; }

        public virtual Furniture Furniture { get; set; }

        public virtual Shipment Shipment { get; set; }
    }
}
