using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;

namespace HRBreakingTheRecords {
    class Program {
        static void Main(string[] args) {

            int[] scores = { 10, 5, 20, 20, 4, 5, 2, 25, 1 };

            var lowest = scores[0];
            var highest = scores[0];

            var lowCount = 0;
            var highCount = 0;

            foreach(var i in scores) {
                if(i > highest) {
                    highest = i;
                    highCount++;
                }
                if(i < lowest) {
                    lowest = i;
                    lowCount++;
                }
            }
            int[] result = { highCount, lowCount };
            return result;
        }
    }
}
