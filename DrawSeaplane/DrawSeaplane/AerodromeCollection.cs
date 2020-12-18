using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Seaplane
{
    class AerodromeCollection
    {
        readonly Dictionary<string, Aerodrome<Vehicle, CircleForm>> aerodromeStages;

        public List<string> Keys => aerodromeStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly char separator = ':';

        public AerodromeCollection(int pictureWidth, int pictureHeight)
        {
            aerodromeStages = new Dictionary<string, Aerodrome<Vehicle, CircleForm>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddAerodrome(string name)
        {
            if (aerodromeStages.ContainsKey(name))
            {
                return;
            }

            aerodromeStages.Add(name, new Aerodrome<Vehicle, CircleForm>(pictureWidth, pictureHeight));
        }

        public void DelAerodrome(string name)
        {
            if (aerodromeStages.ContainsKey(name))
            {
                aerodromeStages.Remove(name);
            }
        }

        public Aerodrome<Vehicle, CircleForm> this[string ind]
        {
            get
            {
                if (aerodromeStages.ContainsKey(ind))
                {
                    return aerodromeStages[ind];
                }
                else
                {
                    return null;
                }
            }
        }

        public Vehicle this[string key, int ind]
        {
            get
            {
                if (aerodromeStages.ContainsKey(key) && ind >= 0)
                {
                    return aerodromeStages[key][ind];
                }
                return null;
            }
        }

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.WriteLine($"AerodromeCollection");

                    foreach (var level in aerodromeStages)
                    {
                        sw.WriteLine($"Aerodrome{separator}{level.Key}");

                        foreach (ITransport plane in level.Value)
                        {
                            if (plane.GetType().Name == "Plane")
                            {
                                sw.Write($"Plane{separator}");

                            }
                            if (plane.GetType().Name == "WaterPlane")
                            {
                                sw.Write($"WaterPlane{separator}");
                            }

                            sw.WriteLine(plane);
                        }
                    }
                }
            }
        }

        public void SaveData(string filename, string aerodromeName)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            if (aerodromeStages.ContainsKey(aerodromeName))
            {
                using (FileStream fs = new FileStream(filename, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                    {
                        sw.WriteLine($"OneAerodrome");

                        sw.WriteLine($"Aerodrome{separator}{aerodromeName}");
                        
                        var level = aerodromeStages[aerodromeName];

                        foreach (ITransport plane in level)
                        {
                            if (plane != null)
                            {
                                if (plane.GetType().Name == "Plane")
                                {
                                    sw.Write($"Plane{separator}");
                                }
                                if (plane.GetType().Name == "WaterPlane")
                                {
                                    sw.Write($"WaterPlane{separator}");
                                }

                                sw.WriteLine(plane);
                            }
                        }
                    }
                }
            }
            throw new FormatException();
        }

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                if (line.Contains("AerodromeCollection"))
                {
                    aerodromeStages.Clear();
                }
                else
                {
                    throw new FormatException();
                }
                line = sr.ReadLine();
                Vehicle plane = null;
                string key = string.Empty;
                while (line != null && line.Contains("Aerodrome"))
                {
                    key = line.Split(separator)[1];                    
                    aerodromeStages.Add(key, new Aerodrome<Vehicle, CircleForm>(pictureWidth, pictureHeight));

                    line = sr.ReadLine();
                    while (line != null && (line.Contains("Plane") || line.Contains("WaterPlane")))
                    {
                        if (line.Split(separator)[0] == "Plane")
                        {
                            plane = new Plane(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "WaterPlane")
                        {
                            plane = new WaterPlane(line.Split(separator)[1]);
                        }
                        var result = aerodromeStages[key] + plane;
                        if (!result)
                        {
                            throw new NullReferenceException();
                        }
                        line = sr.ReadLine();
                    }
                }
            }
        }

        public void LoadOneStage(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                if (!line.Contains("OneAerodrome"))
                {
                    throw new FormatException();
                }
                line = sr.ReadLine();
                Vehicle plane = null;
                string key = string.Empty;
                if (line != null && line.Contains("Aerodrome"))
                {
                    key = line.Split(separator)[1];
                    if (aerodromeStages.ContainsKey(key))
                    {
                        aerodromeStages[key].ClearOneStage();
                    }
                    aerodromeStages.Add(key, new Aerodrome<Vehicle, CircleForm>(pictureWidth, pictureHeight));

                    line = sr.ReadLine();
                    while (line != null && (line.Contains("Plane") || line.Contains("WaterPlane")))
                    {
                        if (line.Split(separator)[0] == "Plane")
                        {
                            plane = new Plane(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "WaterPlane")
                        {
                            plane = new WaterPlane(line.Split(separator)[1]);
                        }
                        var result = aerodromeStages[key] + plane;
                        if (!result)
                        {
                            throw new NullReferenceException();
                        }
                        line = sr.ReadLine();
                    }
                }

                else 
                {
                    throw new FormatException();
                }
            }
        }
    }
}