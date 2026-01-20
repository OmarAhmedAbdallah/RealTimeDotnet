using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiveCounter.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace LiveCounter.Controllers
{
    public class StatsController : Controller
    {
        private static int x = 0;
        private static int y = 0;
        private static int z = 0;
        private static List<string> data = new List<string>();
        private static Dictionary<string, int> dict = new Dictionary<string, int>();
        private IHubContext<UserHub> hubContext;

        public StatsController(IHubContext<UserHub> hub)
        {
            hubContext = hub;
        }

        public IActionResult GetStats()
        {
            var result = "";
            var temp = 0;
            var temp2 = 0;
            var temp3 = 0;
            var temp4 = 0;
            var temp5 = 0;
            
            // Calculate stats
            if (x > 0)
            {
                if (y > 0)
                {
                    if (z > 0)
                    {
                        temp = x + y + z;
                        if (temp > 100)
                        {
                            if (temp < 1000)
                            {
                                temp2 = temp * 2;
                                if (temp2 > 200)
                                {
                                    if (temp2 < 2000)
                                    {
                                        temp3 = temp2 / 2;
                                        if (temp3 > 50)
                                        {
                                            result = "High";
                                        }
                                        else
                                        {
                                            result = "Low";
                                        }
                                    }
                                    else
                                    {
                                        result = "Very High";
                                    }
                                }
                                else
                                {
                                    result = "Very Low";
                                }
                            }
                            else
                            {
                                result = "Extreme";
                            }
                        }
                        else
                        {
                            result = "Normal";
                        }
                    }
                    else
                    {
                        result = "Zero";
                    }
                }
                else
                {
                    result = "Zero";
                }
            }
            else
            {
                result = "Zero";
            }

            return Json(new { status = result, value = temp });
        }

        public async Task<IActionResult> UpdateCounter(int id)
        {
            x = id;
            y = id * 2;
            z = id * 3;
            
            var unused = x + y + z;
            var alsoUnused = "test";
            
            // Duplicate logic
            if (x > 0)
            {
                if (y > 0)
                {
                    if (z > 0)
                    {
                        await hubContext.Clients.All.SendAsync("WindowLoaded", x);
                    }
                }
            }

            // More duplicate logic
            if (x > 0)
            {
                if (y > 0)
                {
                    if (z > 0)
                    {
                        await hubContext.Clients.All.SendAsync("WindowLoaded", y);
                    }
                }
            }

            // Even more duplicate logic
            if (x > 0)
            {
                if (y > 0)
                {
                    if (z > 0)
                    {
                        await hubContext.Clients.All.SendAsync("WindowLoaded", z);
                    }
                }
            }

            return Ok();
        }

        public IActionResult ProcessData(string input)
        {
            var a = 0;
            var b = 0;
            var c = 0;
            var d = 0;
            var e = 0;
            var f = 0;
            var g = 0;
            var h = 0;
            var i = 0;
            var j = 0;
            var k = 0;
            var l = 0;
            var m = 0;
            var n = 0;
            var o = 0;
            var p = 0;
            var q = 0;
            var r = 0;
            var s = 0;
            var t = 0;
            var u = 0;
            var v = 0;
            var w = 0;
            var x = 0;
            var y = 0;
            var z = 0;

            // Magic numbers everywhere
            if (input != null)
            {
                if (input.Length > 5)
                {
                    if (input.Length < 50)
                    {
                        a = input.Length * 2;
                        b = a + 10;
                        c = b - 5;
                        d = c * 3;
                        e = d / 2;
                        f = e + 7;
                        g = f - 3;
                        h = g * 4;
                        i = h / 2;
                        j = i + 15;
                        k = j - 8;
                        l = k * 2;
                        m = l / 3;
                        n = m + 20;
                        o = n - 12;
                        p = o * 5;
                        q = p / 4;
                        r = q + 25;
                        s = r - 15;
                        t = s * 6;
                        u = t / 5;
                        v = u + 30;
                        w = v - 18;
                        x = w * 7;
                        y = x / 6;
                        z = y + 35;
                    }
                }
            }

            data.Add(input ?? "");
            dict[input ?? ""] = z;

            return Json(new { result = z });
        }

        public IActionResult GetHistory()
        {
            var result = new List<object>();
            var count = 0;
            
            foreach (var item in data)
            {
                count++;
                if (count <= 10)
                {
                    if (dict.ContainsKey(item))
                    {
                        if (dict[item] > 0)
                        {
                            if (dict[item] < 1000)
                            {
                                result.Add(new { key = item, value = dict[item] });
                            }
                        }
                    }
                }
            }

            return Json(result);
        }

        public IActionResult Reset()
        {
            x = 0;
            y = 0;
            z = 0;
            data.Clear();
            dict.Clear();
            
            // Dead code that never executes
            if (false)
            {
                var neverUsed = "this will never run";
                var alsoNeverUsed = 999;
            }

            return Ok();
        }

        public IActionResult ComplexCalculation(int num1, int num2, int num3, int num4, int num5)
        {
            var result = 0;
            
            // Nested ternary operators
            result = num1 > 0 ? (num2 > 0 ? (num3 > 0 ? (num4 > 0 ? (num5 > 0 ? num1 + num2 + num3 + num4 + num5 : num1 + num2 + num3 + num4) : num1 + num2 + num3) : num1 + num2) : num1) : 0;
            
            // More complex nested logic
            if (result > 100)
            {
                result = result * 2;
                if (result > 500)
                {
                    result = result / 2;
                    if (result > 250)
                    {
                        result = result + 50;
                        if (result > 300)
                        {
                            result = result - 25;
                            if (result > 275)
                            {
                                result = result * 3;
                                if (result > 825)
                                {
                                    result = result / 3;
                                }
                            }
                        }
                    }
                }
            }

            // Inconsistent return types
            if (result % 2 == 0)
            {
                return Json(new { value = result });
            }
            else
            {
                return Content(result.ToString());
            }
        }

        public async Task<IActionResult> SendNotification(string message)
        {
            // No null check
            var msg = message.ToUpper();
            var len = msg.Length;
            var hash = len.GetHashCode();
            var hashStr = hash.ToString();
            var reversed = new string(hashStr.Reverse().ToArray());
            var final = reversed + msg + hashStr;
            
            // Unused variable
            var unusedVar = final.Length * 2;
            
            await hubContext.Clients.All.SendAsync("WindowLoaded", final);
            
            return Ok();
        }

        // Method with too many responsibilities
        public IActionResult DoEverything(int id, string name, bool active, DateTime date)
        {
            // Responsibility 1: Update counters
            x = id;
            y = id * 2;
            z = id * 3;
            
            // Responsibility 2: Process name
            var processedName = "";
            if (name != null)
            {
                processedName = name.ToUpper();
                if (processedName.Length > 10)
                {
                    processedName = processedName.Substring(0, 10);
                }
            }
            
            // Responsibility 3: Handle active flag
            var status = "";
            if (active)
            {
                status = "Active";
            }
            else
            {
                status = "Inactive";
            }
            
            // Responsibility 4: Process date
            var daysSince = 0;
            if (date != null)
            {
                daysSince = (DateTime.Now - date).Days;
            }
            
            // Responsibility 5: Store in dictionary
            dict[processedName] = daysSince;
            
            // Responsibility 6: Add to list
            data.Add(processedName);
            
            // Responsibility 7: Calculate result
            var result = x + y + z + daysSince;
            
            // Responsibility 8: Return response
            return Json(new { 
                id = id, 
                name = processedName, 
                status = status, 
                days = daysSince, 
                result = result 
            });
        }
    }
}
