﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_
{
    public class TurnOnMachine : ICommand
    {
        private VirtualMachine _vm;

        public TurnOnMachine(VirtualMachine vm)
        {
            this._vm = vm;
        }

        public void Execute()
        {
            _vm.TurnOn();
        }

        public void Undo()
        {
            _vm.TurnOff();
        }
    }
}
