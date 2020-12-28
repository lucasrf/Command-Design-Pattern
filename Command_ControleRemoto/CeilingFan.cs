using System;
using System.Collections.Generic;
using System.Text;

namespace Command_ControleRemoto
{
    class CeilingFan
    {
        private string _description;
        private string _currentSpeed = "standard";
        public CeilingFan(string description)
        {
            _description = description;
        }
        public void HighSpeed()
        {
            _currentSpeed = "high";
            Console.WriteLine(_description + " is set to high speed.");
        }
        public void MediumSpeed()
        {
            _currentSpeed = "medium";
            Console.WriteLine(_description + " is set to medium speed.");
        }
        public void LowSpeed()
        {
            _currentSpeed = "low";
            Console.WriteLine(_description + " is set to low speed.");
        }
        public void GetSpeed()
        {
            Console.WriteLine(_description + " is set to " + _currentSpeed + " speed.");
        }

        public void Off()
        {
            Console.WriteLine(_description + " is off.");
        }
    }
}