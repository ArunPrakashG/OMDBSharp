using OMDBSharp.Exceptions;

namespace OMDBSharp.Models.Requests
{
    internal class GeneralRequest
    {
        private string? _imdbId;
        private string? _title;
        private string? _type;
        private string? _yearOfRelease;
        private string? _plot;
        private string? _callbackName;
        private string? _apiVersion;

        public GeneralRequest WithImdbId(string imdbId)
        {
            if (!string.IsNullOrEmpty(_title))
            {
                throw new OnlyOneArgumentCanBeSpecifiedException();
            }

            _imdbId = imdbId;
            return this;
        }

        public GeneralRequest WithTitle(string title)
        {
            if (!string.IsNullOrEmpty(_imdbId))
            {
                throw new OnlyOneArgumentCanBeSpecifiedException();
            }

            _title = title;
            return this;
        }

        public GeneralRequest WithType(ResultType type)
        {
            _type = type.ToString().ToLowerInvariant();
            return this;
        }

        public GeneralRequest WithYearOfRelease(string yearOfRelease)
        {
            _yearOfRelease = yearOfRelease;
            return this;
        }

        public GeneralRequest WithPlot(Plot plot)
        {
            _plot = plot.ToString().ToLowerInvariant();
            return this;
        }

        public GeneralRequest WithCallbackName(string jsonpCallbackName)
        {
            _callbackName = jsonpCallbackName;
            return this;
        }

        public GeneralRequest WithApiVersion(int version)
        {
            _apiVersion = version.ToString();
            return this;
        }

        public enum Plot
        {
            Short,
            Full,
        }

        public enum ResultType
        {
            Movie,
            Series,
            Episode,
        }
    }
}
