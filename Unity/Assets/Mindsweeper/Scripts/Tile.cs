using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minesweeper
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class Tile : MonoBehaviour
    {
        public int x, y;
        public bool isMine = false;
        public bool isReveled = false;
        [Header("References")]
        public Sprite[] empySprites;
        public Sprite[] mineSprites;
        private SpriteRenderer rend;

        void Awake()
        {
            rend = GetComponent<SpriteRenderer>();
        }

        void Start()
        {
            isMine = Random.value < .05f;
        }

        public void Reveal(int adjacentMines, int mineState = 0)
        {
            isReveled = true;
            if (isMine)
            {
                rend.sprite = mineSprites[mineState];
            }
            else
            {
                rend.sprite = empySprites[adjacentMines];
            }
            
        }
    }
}
