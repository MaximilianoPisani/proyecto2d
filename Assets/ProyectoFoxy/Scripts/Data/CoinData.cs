using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.ProyectoFoxy.Scripts.Data
{
    [CreateAssetMenu(fileName = "Coin_000_Data", menuName = "Data/Coin")]
    public class CoinData : ScriptableObject
    {
        [SerializeField] private AudioClip _pickSound;

        public AudioClip PickSound => _pickSound;
    
    }



}