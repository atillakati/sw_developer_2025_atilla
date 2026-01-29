namespace Events_Grundlagen
{
    public class MaxSpeedReachedEventArgs : EventArgs
    {
        private int _maxSpeed;        

        public MaxSpeedReachedEventArgs(int maxSpeed)
        {
            _maxSpeed = maxSpeed;
        }

        public int MaxSpeed
        {
            get { return _maxSpeed; }
        }
    }
}