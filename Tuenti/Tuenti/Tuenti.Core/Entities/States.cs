﻿namespace Tuenti.Tuenti.Core.Entities
{
    public class States
    {
        public int Id { get; set; }
        public string Content { get; set; }

        //Navegacion
        public virtual User User { get; set; }
    }
}