using System;

namespace WASMrozvrh.Models
{
    public class HodinaModel
    {
        public int Id { get; set; }
        public HodinaStatuses Status { get; set; }
        public string NazovHodiny { get; set; }
    }

    public enum HodinaStatuses
    {
        P1,P2,P3,P4,P5,P6,
        U1,U2,U3,U4,U5,U6,
        S1,S2,S3,S4,S5,S6,
        Stv1,Stv2,Stv3,Stv4,Stv5,Stv6,
        Pi1,Pi2,Pi3,Pi4,Pi5,Pi6
    }
}
