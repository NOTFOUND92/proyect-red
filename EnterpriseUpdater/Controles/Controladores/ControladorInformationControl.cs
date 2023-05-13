namespace EnterpriseUpdater.Controles.Controladores
{
    public sealed class ControladorInformationControl
    {
        private readonly InformationControl _control;
        private List<UserControl> _listOfControls = new List<UserControl>();
        private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();

        private UserControl controlPrincipal = null;
        private UserControl controlSecundario = null;
        private int indice = 1;

        public ControladorInformationControl(InformationControl control)
        {
            _control = control;
            _control.Load += new EventHandler(Load);
            _timer.Tick += new EventHandler(StartAnimation);
        }

        private void Load(object sender, EventArgs e)
        {
            if (_listOfControls.Count > 0)
            {
                controlPrincipal = _listOfControls[0];
                controlPrincipal.Location = new Point(0, 0);

                _control.Controls.Add(controlPrincipal);
            }

            if (_listOfControls.Count > 1)
            {
                _timer.Interval = _control.DuracionTransicion * 1000;
                _timer.Enabled = true;
            }
        }

        public void NotificationAdd(UserControl control)
        {
            control.Size = _control.Size;
            _listOfControls.Add(control);
        }

        private async void StartAnimation(object sender, EventArgs e)
        {
            _timer.Enabled = false;
            await Task.Run(() => RunAnimationAsync());
        }

        private async Task RunAnimationAsync()
        {
            while (true)
            {
                controlPrincipal = controlSecundario ?? _listOfControls[0];
                var locationPnl = controlPrincipal.Location.X + controlPrincipal.Width;

                if (_listOfControls.Count > 1 && indice <= _listOfControls.Count - 1)
                {
                    controlSecundario = _listOfControls[indice];

                    _control.Invoke(new Action(() => { controlSecundario.Location = new Point(_control.Width, _control.Location.Y); }));
                    _control.Invoke(new Action(() => { _control.Controls.Add(controlSecundario); }));
                }

                while (locationPnl > 0)
                {
                    _control.Invoke(new Action(() => { controlPrincipal.Location = new Point(controlPrincipal.Location.X - 8, controlPrincipal.Location.Y); }));

                    if (controlSecundario != null)
                    {
                        _control.Invoke(new Action(() => { controlSecundario.Location = new Point(controlSecundario.Location.X - 8, controlSecundario.Location.Y); }));
                    }

                    locationPnl = controlPrincipal.Location.X + controlPrincipal.Width;
                }

                if (indice >= _listOfControls.Count - 1)
                {
                    indice = 0;
                }
                else
                {
                    indice++;
                }

                _control.Invoke(new Action(() => { _control.Controls.Remove(controlPrincipal); }));

                // Esperar un tiempo de transición antes de iniciar la siguiente animación
               await Task.Delay(_control.DuracionTransicion * 1000);
            }
        }
    }
}