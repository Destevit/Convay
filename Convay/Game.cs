using Convay.Core.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Convay.Core
{
    /// <summary>
    /// Klasa automatu komórkowego
    /// </summary>
    public sealed class Game : IGame
    {
        private IRules rules;
        private IGrid grid;
        private IEngine engine;
        private TimeSpan interval;
        private CancellationTokenSource cancellation;
        private bool isRunning;

        /// <summary>
        /// Właściwość która zwraca informację, czy gra jest uruchomiona
        /// </summary>
        public bool IsRunning {
            get
            {
                return isRunning;
            }
            private set
            {
                isRunning = value;
                GameStateChanged?.Invoke(this, value);
            }
        }

        /// <summary>
        /// Konstruuje grę
        /// </summary>
        /// <param name="engine">instancja silnika</param>
        /// <param name="grid">instancja siatki</param>
        /// <param name="rules">instancja zasad</param>
        /// <param name="interval">interwał pomiędzy krokami</param>
        public Game(IEngine engine, IGrid grid, IRules rules, TimeSpan interval)
        {
            this.rules = rules;
            this.grid = grid;
            this.engine = engine;
            this.interval = interval;
        }

        /// <summary>
        /// Właściwość z zasadami gry
        /// </summary>
        public IRules Rules
        {
            get
            {
                return rules;
            }

            set
            {
                bool wasRunning = IsRunning;
                Stop();
                RulesChanged?.Invoke(this, new RulesChangedEventArgs(value));
                rules = value;
                if (wasRunning)
                    Start();
            }
        }

        /// <summary>
        /// Właściwość zwracająca/ustawiająca wewnętrzną siatkę silnika
        /// </summary>
        public IGrid Grid
        {
            get
            {
                return grid;
            }

            set
            {
                bool wasRunning = IsRunning;
                Stop();
                GridChanged?.Invoke(this, new GridChangedEventArgs(value, rules));
                grid = value;
                if (wasRunning)
                    Start();
            }
        }

        /// <summary>
        /// Interwał pomiędzy krokami gry
        /// </summary>
        public TimeSpan Interval
        {
            get
            {
                return interval;
            }

            set
            {
                bool wasRunning = IsRunning;
                Stop();
                interval = value;
                if(wasRunning)
                    Start();
            }
        }

        /// <summary>
        /// Właściwość z silnikiem gry
        /// </summary>
        public IEngine Engine
        {
            get
            {
                return engine;
            }

            set
            {
                bool wasRunning = IsRunning;
                Stop();
                engine = value;
                if (wasRunning)
                    Start();
            }
        }

        /// <summary>
        /// Zdarzenie wywoływane po zmianie zasad
        /// </summary>
        public event EventHandler<RulesChangedEventArgs> RulesChanged;
        /// <summary>
        /// Zdarzenie wywoływane po zmianie siatki
        /// </summary>
        public event EventHandler<GridChangedEventArgs> GridChanged;
        
        /// <summary>
        /// Zdarzenie wywoływane po zmianie stanu gry
        /// </summary>
        public event EventHandler<bool> GameStateChanged;

        /// <summary>
        /// Metoda startująca grę
        /// </summary>
        public async void Start()
        {
            Stop();
            IsRunning = true;
            cancellation = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellation.Token;
            while(!cancellationToken.IsCancellationRequested)
            {
                IGrid newGrid = engine.TakeStep(grid, rules);
                if(!cancellationToken.IsCancellationRequested)
                {
                    grid = newGrid;
                    if (interval.Ticks != 0)
                        try
                        {
                            await Task.Delay(interval, cancellationToken);
                        } catch(Exception) { }
                    GridChanged?.Invoke(this, new GridChangedEventArgs(grid, rules));
                }
            }
        }

        /// <summary>
        /// Metoda zatrzymująca grę
        /// </summary>
        public void Stop()
        {
            IsRunning = false;
            cancellation?.Cancel();
        }

        /// <summary>
        /// Losuje siatkę gry
        /// </summary>
        public void Randomize()
        {
            grid.Initialize(grid.XSize, grid.YSize);
            grid.Randomize();
            GridChanged?.Invoke(this, new GridChangedEventArgs(grid, rules));
        }
    }
}
