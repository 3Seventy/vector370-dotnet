namespace ThreeSeventy.Vector.Client
{
    /// <summary>
    /// Event schedule type
    /// </summary>
    /// <remarks>
    /// Currently the only supported types are: Now, OneTime and Daily.
    /// </remarks>
    public enum ScheduleType
    {
        /// <summary>
        /// Will execute the action at a specified time in the future
        /// </summary>
        OneTime = 2,

        /// <summary>
        /// Will Execute the action once every second.
        /// </summary>
        /// <remarks>
        /// This is a place holder value and is not supported.
        /// </remarks>
        Second  = 3,

        /// <summary>
        /// Will Execute the action once every minute.
        /// </summary>
        /// <remarks>
        /// This is a place holder value and is not supported.
        /// </remarks>
        Minute  = 4,

        /// <summary>
        /// Will Execute the action once every hour
        /// </summary>
        /// <remarks>
        /// This is a place holder value and is not supported.
        /// </remarks>
        Hour    = 5,

        /// <summary>
        /// Will execute the action at a specified time every day.
        /// </summary>
        Daily   = 6,

        /// <summary>
        /// Will execute the action at a specified time on specified days of the week.
        /// </summary>
        /// <remarks>
        /// This is a place holder value and is not supported.
        /// </remarks>
        Weekly  = 7,

        /// <summary>
        /// Will execute the action at a specified time on specified days of the month
        /// </summary>
        /// <remarks>
        /// This is a place holder value and is not supported.
        /// </remarks>
        Monthly = 8,

        /// <summary>
        /// Will execute the action once every year.
        /// </summary>
        /// <remarks>
        /// This is a place holder value and is not supported.
        /// </remarks>
        Yearly  = 9
    }
}