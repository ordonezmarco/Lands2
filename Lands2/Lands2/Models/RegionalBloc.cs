

namespace Lands2.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    class RegionalBloc
    {
        [JsonProperty(PropertyName = "acronym")]
        public string Acronym
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "name")]
        public string Name
        {
            get;
            set;
        }

        public List<object> otherAcronyms
        {
            get;
            set;
        }

        public List<object> otherNames
        {
            get;
            set;
        }
    }
}
