// See https://aka.ms/new-console-template for more information
using System.Runtime.Versioning;
using System.Speech.Synthesis;


[SupportedOSPlatform("windows")]
internal class Program
{

    private static ActionItem calentamiento1 = new ActionItem
    {
        Name = "Ejercicio Calentamiento.",
        SpeakText = "Ejercicio Calentamiento",
        Items = {
                    ActionItem.CreateDelay(0, "tobillo derecho"),
                    ActionItem.CreateDelay(10, "tobillo izquierdo"),
                    ActionItem.CreateDelay(10, "rodillas"),
                    ActionItem.CreateDelay(10, "cintura"),
                    ActionItem.CreateDelay(10, "giro de cadera"),
                    ActionItem.CreateDelay(10, "circulo con la cadera"),
                    ActionItem.CreateDelay(10, "elevamos una rodilla y brazo"),
                    ActionItem.CreateDelay(10, "hombros adelante y atrás"),
                    ActionItem.CreateDelay(10, "movilidad de cuello arriba y abajo. A un lado y al otro"),
                    ActionItem.CreateDelay(10, "Cuerpo a un lado y al otro con manos arriba y abajo"),
                    ActionItem.CreateDelay(10, "Puño a un lado y a otro"),
                    ActionItem.CreateDelay(10, "Rodilla arriba y extension de bazo"),
                    ActionItem.CreateDelay(10, "Apertura piernas y hombro"),
                    ActionItem.CreateDelay(10, "pierna arriba"),
                    ActionItem.CreateDelay(10, "salto mariposa"),
                    ActionItem.CreateDelay(10, "salto mariposa"),
                    ActionItem.CreateDelay(10, "camino rápido"),
                    ActionItem.CreateDelay(10, "estiramos brazos manos en cadera y brazo arriba"),
                    ActionItem.CreateDelay(10, "giro de hombro derecho"),
                    ActionItem.CreateDelay(10, "giro de hombro izquierdo"),
                    ActionItem.CreateDelay(10, "salto mariposa"),
                    ActionItem.CreateDelay(10, "salto mariposa"),
                    ActionItem.CreateDelay(10, "salto mariposa"),
                    ActionItem.CreateDelay(10, "sentadillas con salto"),
                    ActionItem.CreateDelay(10, "estiramos brazos manos en cadera y brazo arriba"),
                    ActionItem.Create("Fin de ejercicio"),
                },
    };

    private static async Task Main(string[] args)
    {
        var calendarProcessor = new CalendarProcessor();

        var time = await calendarProcessor.Run(new List<ActionItem>
        {
            // calentamiento1,
            // ActionItem.Create("Descanso de 1 minuto"),
            // ActionItem.CreateDelay(60),  
            new ActionItem {
                Name = "Ejercicio 1.",
                Detail = @" 
                https://www.youtube.com/watch?v=Uy2nUNX38xE

                Se realizan 3 series de 8 a 12 burpee
                ",
                SpeakText ="Ejercicio 1, Burpee (el soldadito). Se realizan 3 series de 10 repeticiones",
                Items = {
                    ActionItem.CreateDelay(10, "Primera serie"),
                    ActionItem.CreateDelay(60),
                    ActionItem.Create("Descanso de 1 minuto"),
                    ActionItem.CreateDelay(60, "Segunda serie"),
                    ActionItem.CreateDelay(60),
                    ActionItem.Create("Descanso de 1 minuto"),
                    ActionItem.CreateDelay(60, "Tercera y última serie"),
                    ActionItem.CreateDelay(60),
                    ActionItem.Create("Fin de ejercicio"),
                },
            },
            ActionItem.Create("Descanso de 1 minuto"),
            ActionItem.CreateDelay(60),
            new ActionItem {
                Name = "Ejercicio 2.",
                SpeakText ="Ejercicio 2, Bicicleta en el aire. Se realizan 4 series de 30 repeticiones ",
                Items = {
                    ActionItem.CreateDelay(10, "Primera serie"),
                    ActionItem.CreateDelay(60),
                    ActionItem.Create("Descanso de 1 minuto"),
                    ActionItem.CreateDelay(60, "Segunda serie"),
                    ActionItem.CreateDelay(60),
                    ActionItem.Create("Descanso de 1 minuto"),
                    ActionItem.CreateDelay(60, "Tercera serie"),
                    ActionItem.CreateDelay(60),
                    ActionItem.Create("Descanso de 1 minuto"),
                    ActionItem.CreateDelay(60, "Cuarta y última serie"),
                    ActionItem.CreateDelay(60),
                    ActionItem.Create("Fin de ejercicio"),
                },
            },
            ActionItem.Create("Descanso de 1 minuto"),
            ActionItem.CreateDelay(60),
            new ActionItem {
                Name = "Ejercicio 3.",
                SpeakText ="Ejercicio 3, Escalador cruzado. Se realizan 4 series de 1 minuto cada una sin parar",
                Items = {
                    ActionItem.CreateDelay(10, "Primera serie"),
                    ActionItem.CreateDelay(60),
                    ActionItem.Create("Descanso de 30 segundos"),
                    ActionItem.CreateDelay(30, "Segunda serie"),
                    ActionItem.CreateDelay(60),
                    ActionItem.Create("Descanso de 30 segundos"),
                    ActionItem.CreateDelay(30, "Tercera serie"),
                    ActionItem.CreateDelay(60),
                    ActionItem.Create("Descanso de 30 segundos"),
                    ActionItem.CreateDelay(30, "Cuarta y última serie"),
                    ActionItem.CreateDelay(60),
                    ActionItem.Create("Fin de ejercicio"),
                },
            },
            ActionItem.Create("Descanso de 1 minuto"),
            ActionItem.CreateDelay(60),
            new ActionItem {
                Name = "Ejercicio 4.",
                SpeakText ="Ejercicio 4, Plancha. Se realizan 3 series de 30 segundos cada una",
                Items = {
                    new ActionItem{
                        DelayTime = TimeSpan.FromSeconds(10),
                        RepeatCount = 3,
                        Items = {
                            ActionItem.Create("Serie plancha"),
                            ActionItem.CreateDelay(30),
                            ActionItem.Create("Descanso de 30 segundos"),
                            ActionItem.CreateDelay(30),
                        }
                    },
                    ActionItem.Create("Fin de ejercicio"),
                },
            },
            ActionItem.Create("Descanso de 1 minuto"),
            ActionItem.CreateDelay(60),
            new ActionItem {
                Name = "Ejercicio 5.",
                SpeakText ="Ejercicio 5, Abdominal inverso. Se realizan 4 series de 30 repeticiones por minuto",
                Items = {
                    new ActionItem{
                        DelayTime = TimeSpan.FromSeconds(10),
                        RepeatCount = 4,
                        Items = {
                            ActionItem.Create("Serie Abdominal inverso"),
                            ActionItem.CreateDelay(60),
                            ActionItem.Create("Descanso de 1 minuto"),
                            ActionItem.CreateDelay(60),
                        }
                    },
                    ActionItem.Create("Fin de ejercicio"),
                },
            },
            ActionItem.Create("Descanso de 1 minuto"),
            ActionItem.CreateDelay(60),
            new ActionItem {
                Name = "Ejercicio 6.",
                SpeakText ="Ejercicio 6, Abdominal completo. Se realizan 4 series de 30 repeticiones en 1 minuto",
                Items = {
                    new ActionItem{
                        DelayTime = TimeSpan.FromSeconds(10),
                        RepeatCount = 4,
                        Items = {
                            ActionItem.Create("Serie Abdominal completo"),
                            ActionItem.CreateDelay(60),
                            ActionItem.Create("Descanso de 1 minuto"),
                            ActionItem.CreateDelay(60),
                        }
                    },
                    ActionItem.Create("Fin de ejercicio"),
                },
            },
            ActionItem.Create("Descanso de 1 minuto"),
            ActionItem.CreateDelay(60),
            new ActionItem {
                Name = "Ejercicio 7.",
                SpeakText ="Ejercicio 7, Posición de barco. Se realizan 3 series de 30 segundos",
                Items = {
                    new ActionItem{
                        DelayTime = TimeSpan.FromSeconds(10),
                        RepeatCount = 3,
                        Items = {
                            ActionItem.Create("Serie Posición de barco"),
                            ActionItem.CreateDelay(30),
                            ActionItem.Create("Descanso de 1 minuto"),
                            ActionItem.CreateDelay(60),
                        }
                    },
                    ActionItem.Create("Fin de ejercicio"),
                },
            },
            ActionItem.Create("Descanso de 1 minuto"),
            ActionItem.CreateDelay(60),
            new ActionItem {
                Name = "Ejercicio 8.",
                SpeakText ="Ejercicio 8, Giro Ruso. Se realizan 3 series de 8 repeticiones en 30 segundos",
                Items = {
                    new ActionItem{
                        DelayTime = TimeSpan.FromSeconds(10),
                        RepeatCount = 3,
                        Items = {
                            ActionItem.Create("Serie Giro Ruso"),
                            ActionItem.CreateDelay(30),
                            ActionItem.Create("Descanso de 1 minuto"),
                            ActionItem.CreateDelay(30),
                        }
                    },
                    ActionItem.Create("Fin de ejercicio"),
                },
            },
            ActionItem.Create("Descanso de 1 minuto"),
            ActionItem.CreateDelay(60),
            new ActionItem {
                Name = "Ejercicio 9.",
                SpeakText ="Ejercicio 9, Sentadillas con salto. Se realizan 2 series de 1 minuto",
                Items = {
                    new ActionItem{
                        DelayTime = TimeSpan.FromSeconds(10),
                        RepeatCount = 3,
                        Items = {
                            ActionItem.Create("Serie Sentadillas con salto"),
                            ActionItem.CreateDelay(60),
                            ActionItem.Create("Descanso de 1 minuto"),
                            ActionItem.CreateDelay(60),
                        }
                    },
                    ActionItem.Create("Fin de ejercicio"),
                },
            },
        });

        calendarProcessor.Speak($"Fin de ejercicios, tiempo total de {time}");
    }

}