/// ************************************************************************************************************ //
/// <Auteur> Marc-Olivier Thibault </Auteur>
/// 
/// <Creation> 27-07-2021 </Creation>
/// 
/// <Description> 
///     Objet représentant l'état d'une commande.
///     Could be just for testing purpose.
/// </Description>
/// ************************************************************************************************************ //

using System.ComponentModel;
//using System.Management.Automation;
using System.Linq;
using System;

namespace PAUL.Models.Command
{
    public class CommandStatus
    {
        public int ID { get; }
        public String Description { get; set; }

        public CommandStatus(string Description)
        {
            this.Description = Description;
        }
        public CommandStatus(){ this.Description = ""; }
    }
}