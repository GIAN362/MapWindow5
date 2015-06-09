﻿namespace MW5.Plugins.TableEditor
{
    public enum TableEditorCommand
    {
        Close = 0,
        SaveChanges = 1,
        ZoomToSelected = 2,
        ShowSelected = 3,
        StartEdit = 4,
        AddField = 5,
        RemoveField = 6,
        RenameField = 7,
        SelectAll = 8,
        ClearSelection = 9,
        InvertSelection = 10,
        CalculateField = 11,
        Join = 12,
        LayoutTabbed = 13,
        LayoutHorizontal = 14,
        LayoutVertical = 15,
        UpdateMeasurements = 16,
        Find = 17,
        FindNext = 18,
    }

    /// <summary>
    /// The measurement types.
    /// </summary>
    /// <remarks>This should be in the MW core</remarks>
    public enum MeasurementTypes
    {
        /// <summary>The area.</summary>
        Area,

        /// <summary>The perimeter.</summary>
        Perimeter,

        /// <summary>The length.</summary>
        Length
    }

    /// <summary>
    /// Groups of fuctions for field calculator
    /// </summary>
    public enum CalculatorFunction
    {
        Shapes = 0,
        Operators = 1,
        Booleans = 2,
        Maths = 3,
        Angles = 4,
        Statistics = 5,
        Time = 6,
        Other = 7,
        Constants = 8,
    }

    public enum JoinsCommand
    {
        Join = 0,
        EditJoin = 1,
        Stop = 2,
        StopAll = 3,
    }

    public enum JoinSourceType
    {
        Dbf = 0,
        Xls = 1,
        Csv = 2,
    }

    public enum UpdateMeasurementType
    {
        Ignore = 0,
        ExitingField = 1,
        NewField = 2,
    }
}
