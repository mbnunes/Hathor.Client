﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hathor.Models.Requests
{
    public class StartRequest
    {
        [Required]
        [JsonProperty(PropertyName = "wallet-id")]
        public string WalletId { get; set; }

        /// <summary>
        /// Passphrase of the wallet that will be created.
        /// </summary>
        [JsonProperty(PropertyName = "passphrase")]
        public string? Passphrase { get; set; }

        /// <summary>
        /// Key of the corresponding seed in the config file to create the wallet.
        /// </summary>
        [JsonProperty(PropertyName = "seedKey")]
        [Required]
        public string SeedKey { get; set; }

        public StartRequest(string walletId, string seedKey = "default", string? passphrase = null)
        {
            WalletId = walletId;
            SeedKey = seedKey;
            Passphrase = passphrase;
        }

    }
}
