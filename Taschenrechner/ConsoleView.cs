﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class ConsoleView
    {
        private RechnerModel model;

        public ConsoleView(RechnerModel model)
        {
            this.model = model;
        }

        public double HoleZahlVomBenutzer()
        {
            string zahl;
            Console.Write("Bitte gib eine Zahl für die Berechnung ein: ");
            zahl = Console.ReadLine();

            return Convert.ToDouble(zahl);
        }

        public string HoleOperatorVomBenutzer()
        {
            Console.Write("Bitte gib die auszuführende Operation ein (+, -, *, /): ");
            return Console.ReadLine();
        }

        public string WarteAufEndeDurchBenutzer()
        {
            Console.Write("Zum Beenden bitte - Return - drücken!");
            return Console.ReadLine();
        }

        public void GibResultatAus()
        {
            // Division durch 0 anmerken
            if ((model.ZweiteZahl == 0) && (model.Operation == "/"))
            {
                Console.WriteLine("Division durch 0 ist nicht definiert, Kollege!");
            }
            // Kein gültiger Rechenoperand anmerken
            else if ((model.Operation != "+") && (model.Operation != "-") && (model.Operation != "*") && (model.Operation != "/"))
            {
                Console.WriteLine("Du hast keinen gültigen Rechenoperator eingegeben!");
            }
            else
            {
            Console.WriteLine("Das Resultat ist: {0}", model.Resultat);
            }
            Console.WriteLine();
        }
    }
}
