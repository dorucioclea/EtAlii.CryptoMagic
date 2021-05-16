﻿namespace EtAlii.BinanceMagic.Service.Trading.Circular
{
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;

    public partial class CircularView
    {
        private readonly Experiment[] _experiments;
        private Experiment _currentExperiment;

        [Parameter] public string Id { get; set; }

        public CircularView()
        {
            _experiments = new[]
            {
                new Experiment { Name = "Circular: BTC-BNB", Steps = new []{ new ExperimentStep(), new ExperimentStep(), } },
                new Experiment { Name = "Circular: LTC-XMR" },
                new Experiment { Name = "Surfing: BTC-BNB-XMR" },
            };
            _currentExperiment = _experiments.First();
            UpdateExperiments();
        }
        
        // private void SelectExperiment(string experimentName)
        // {
        //     InvokeAsync(() =>
        //     {
        //         _currentExperiment = _experiments.SingleOrDefault(e => e.Name == experimentName);
        //         
        //         UpdateExperiments();
        //         StateHasChanged();
        //     });
        // }

        private void UpdateExperiments()
        {
            foreach (var experiment in _experiments)
            {
                experiment.IsActive = _currentExperiment == experiment;
            }
        }
        
        protected override Task OnInitializedAsync()
        {
            return Task.CompletedTask;
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            _algorithmRunnerService.Tick += () =>
            {
                InvokeAsync(StateHasChanged);
            };
        }
    }
}