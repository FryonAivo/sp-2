using System;
using System.Collections.Concurrent;
using System.Text;
using Microsoft.Extensions.Logging;

namespace WelcomeExtended.Loggers
{
    class HashLogger : ILogger
    {


        private readonly ConcurrentDictionary<int, string> _logMessages = new ConcurrentDictionary<int, string>();
        private readonly string _name;
        private int _currentIndex = 0; // Keeps track of the last index

        public HashLogger(string name)
        {
            this._name = name;
            AddLogMessage(name);
        }

        public void AddLogMessage(string message)
        {
            _logMessages[_currentIndex++] = message;
        }

        public IDisposable BeginScope<TState>(TState state) where TState : notnull
        {
            // This logger no longer support scopes.
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            var message = formatter(state, exception);

            switch (logLevel)
            {
                case LogLevel.Critical:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case LogLevel.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            Console.WriteLine("-LOGGER-");
            var messageToBeLogged = new StringBuilder();
            messageToBeLogged.Append($"[{logLevel}]");
            messageToBeLogged.AppendFormat("[{0}]", _name);
            Console.WriteLine(messageToBeLogged);
            Console.WriteLine($"{formatter(state, exception)}");
            Console.WriteLine("-LOGGER-");
            Console.ResetColor();
            _logMessages[eventId.Id] = message;
        }
    }
}