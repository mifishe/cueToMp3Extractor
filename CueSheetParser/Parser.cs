using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CueSheetParser
{





    public class Parser
    {

        public static CueSheet Parse(string Body)
        {

            var commandToPropertyMap = (typeof(CueSheet)).GetProperties()
                .Select(pi => new KeyValuePair<string, PropertyInfo>(pi.Name.ToUpper(), pi))
                .ToDictionary(x => x.Key, x => x.Value);

            var cue = new CueSheet();

            foreach (var line in Body.Split('\n'))
            {
                var terms = line.Trim().Split(' ');
                var command = terms[0].ToUpper();
                var value = String.Join(" ", terms.Skip(1)).Trim();
                if (commandToPropertyMap.ContainsKey(command))
                {
                    
                    commandToPropertyMap[command].SetValue(cue, PreProcessValue(command, value));
                } else
                {
                    switch(command)
                    {
                        case "FILE":
                            //todo
                            break;
                        default:
                            break;
                    }
                }
                
            }
            return cue;
        }

        private static string PreProcessValue(string command, string value)
        {
            var processedValue = value;
            if(processedValue[0] == '"' && processedValue[processedValue.Length - 1] == '"')
            {
                processedValue = processedValue.Substring(1, processedValue.Length - 2);
            }
            return processedValue;
        }


    }
}
