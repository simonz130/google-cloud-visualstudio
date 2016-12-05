﻿namespace GoogleCloudExtension.DataSources
{
    public interface IGcsFileOperation
    {
        void Progress(double value);

        void Completed();

        void Cancelled();

        void Error(DataSourceException ex);
    }
}
