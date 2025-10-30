using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Solution {
    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine().Trim());
        
        StringBuilder text = new StringBuilder();
        Stack<string> history = new Stack<string>();
        
        for (int i = 0; i < q; i++) {
            string[] operation = Console.ReadLine().Trim().Split(' ');
            int type = Convert.ToInt32(operation[0]);
            
            if (type == 1) {
                // Append string
                history.Push(text.ToString());
                text.Append(operation[1]);
            } else if (type == 2) {
                // Delete last k characters
                int k = Convert.ToInt32(operation[1]);
                history.Push(text.ToString());
                text.Length -= k;
            } else if (type == 3) {
                // Print k-th character
                int k = Convert.ToInt32(operation[1]);
                Console.WriteLine(text[k - 1]);
            } else if (type == 4) {
                // Undo last operation
                if (history.Count > 0) {
                    text.Clear();
                    text.Append(history.Pop());
                }
            }
        }
    }
}
