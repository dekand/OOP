using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab7
{
    internal class PlayersClub
    {
        private static string[] players = new string[] {
"Нефедов А. М.",
"Воробьев М. А.",
"Астахов Ф. И.",
"Ершова Д. О.",
"Сафонова В. М.",
"Кузьмин В. М.",
"Соболев С. Д.",
"Новикова Е. А.",
"Тарасов М. А.",
"Козлов А. С.",
"Островская М. И.",
"Хохлова А. С."
        };
        public static string[] getPlayers { get {  return players; } }
    }
}
