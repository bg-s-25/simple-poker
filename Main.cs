/**
 * Simple Poker -> Class MAIN
 * Author: Bobby Georgiou
 * Date: Sep 2018
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Simple_Poker
{
    public partial class Main : Form
    {
        readonly string[] CARD_NAMES = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        readonly string[] CARD_SYMBOLS = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        readonly string[] SUIT_NAMES = new string[] { "Spade", "Heart", "Club", "Diamond" };
        readonly int[] ROYALFLUSH_PTS = new int[] { 0, 250, 500, 750, 1000, 4000 };
        readonly int[] STRAIGHTFLUSH_PTS = new int[] { 0, 50, 100, 150, 200, 250 };
        readonly int[] FOUROFAKIND_PTS = new int[] { 0, 25, 50, 75, 100, 125 };
        readonly int[] FULLHOUSE_PTS = new int[] { 0, 9, 18, 27, 36, 45 };
        readonly int[] FLUSH_PTS = new int[] { 0, 6, 12, 18, 24, 30 };
        readonly int[] STRAIGHT_PTS = new int[] { 0, 4, 8, 12, 16, 20 };
        readonly int[] THREEOFAKIND_PTS = new int[] { 0, 3, 6, 9, 12, 15 };
        readonly int[] TWOPAIR_PTS = new int[] { 0, 2, 4, 6, 8, 10 };
        readonly int[] PAIR_PTS = new int[] { 0, 1, 2, 3, 4, 5 };
        List<int> specialStraightOrder;
        // cardInfo - keys 0-52; value indices: 0 = card symbol and suit symbol, 1 = card name, 2 = suit name, 3 = long name, 4 = card image bitmap, 5 = internal ordering constant
        Dictionary<int, object[]> cardInfo;
        List<int> deck; // card indices
        // centerCards - keys 1-5; value indices: 0 = card index, 1 = card held (bool)
        Dictionary<int, object[]> centerCards;
        List<int> nonHeldCards; int timerCurIndex = 0; int animationTimerStep = 0;
        int userCredits, curBetCredits, userWinCredits;
        bool dealing;
        int curTurn, maxTurns; // betting allowed only at max turn
        Random r; int seed;

        public Main()
        {
            InitializeComponent();
            cardInfo = new Dictionary<int, object[]>(); centerCards = new Dictionary<int, object[]>();
            deck = new List<int>();
            centerCards = new Dictionary<int, object[]>();
            specialStraightOrder = new List<int>() { 1, 10, 11, 12, 13 };
            seed = (int)DateTime.Now.Ticks;
            r = new Random(seed);

            // set up deck, center cards
            ResetDeck();
            for (int i = 1; i < 6; i++)
            {
                centerCards.Add(i, new object[] { 0, false });
            }

            // add info to dictionary
            cardInfo.Add(0, new object[] { "", "", "", "", Properties.Resources.back, 0 });

            cardInfo.Add(1, new object[] { "A♠", "Ace", "Spade", "SpadeAce", Properties.Resources.ace_of_spades, 1 });
            cardInfo.Add(2, new object[] { "A♥", "Ace", "Heart", "HeartAce", Properties.Resources.ace_of_hearts, 1 });
            cardInfo.Add(3, new object[] { "A♣", "Ace", "Club", "ClubAce", Properties.Resources.ace_of_clubs, 1 });
            cardInfo.Add(4, new object[] { "A♦", "Ace", "Diamond", "DiamondAce", Properties.Resources.ace_of_diamonds, 1 });

            cardInfo.Add(5, new object[] { "2♠", "2", "Spade", "Spade2", Properties.Resources._2_of_spades, 2 });
            cardInfo.Add(6, new object[] { "2♥", "2", "Heart", "Heart2", Properties.Resources._2_of_hearts, 2 });
            cardInfo.Add(7, new object[] { "2♣", "2", "Club", "Club2", Properties.Resources._2_of_clubs, 2 });
            cardInfo.Add(8, new object[] { "2♦", "2", "Diamond", "Diamond2", Properties.Resources._2_of_diamonds, 2 });

            cardInfo.Add(9, new object[] { "3♠", "3", "Spade", "Spade3", Properties.Resources._3_of_spades, 3 });
            cardInfo.Add(10, new object[] { "3♥", "3", "Heart", "Heart3", Properties.Resources._3_of_hearts, 3 });
            cardInfo.Add(11, new object[] { "3♣", "3", "Club", "Club3", Properties.Resources._3_of_clubs, 3 });
            cardInfo.Add(12, new object[] { "3♦", "3", "Diamond", "Diamond3", Properties.Resources._3_of_diamonds, 3 });

            cardInfo.Add(13, new object[] { "4♠", "4", "Spade", "Spade4", Properties.Resources._4_of_spades, 4 });
            cardInfo.Add(14, new object[] { "4♥", "4", "Heart", "Heart4", Properties.Resources._4_of_hearts, 4 });
            cardInfo.Add(15, new object[] { "4♣", "4", "Club", "Club4", Properties.Resources._4_of_clubs, 4 });
            cardInfo.Add(16, new object[] { "4♦", "4", "Diamond", "Diamond4", Properties.Resources._4_of_diamonds, 4 });

            cardInfo.Add(17, new object[] { "5♠", "5", "Spade", "Spade5", Properties.Resources._5_of_spades, 5 });
            cardInfo.Add(18, new object[] { "5♥", "5", "Heart", "Heart5", Properties.Resources._5_of_hearts, 5 });
            cardInfo.Add(19, new object[] { "5♣", "5", "Club", "Club5", Properties.Resources._5_of_clubs, 5 });
            cardInfo.Add(20, new object[] { "5♦", "5", "Diamond", "Diamond5", Properties.Resources._5_of_diamonds, 5 });

            cardInfo.Add(21, new object[] { "6♠", "6", "Spade", "Spade6", Properties.Resources._6_of_spades, 6 });
            cardInfo.Add(22, new object[] { "6♥", "6", "Heart", "Heart6", Properties.Resources._6_of_hearts, 6 });
            cardInfo.Add(23, new object[] { "6♣", "6", "Club", "Club6", Properties.Resources._6_of_clubs, 6 });
            cardInfo.Add(24, new object[] { "6♦", "6", "Diamond", "Diamond6", Properties.Resources._6_of_diamonds, 6 });

            cardInfo.Add(25, new object[] { "7♠", "7", "Spade", "Spade7", Properties.Resources._7_of_spades, 7 });
            cardInfo.Add(26, new object[] { "7♥", "7", "Heart", "Heart7", Properties.Resources._7_of_hearts, 7 });
            cardInfo.Add(27, new object[] { "7♣", "7", "Club", "Club7", Properties.Resources._7_of_clubs, 7 });
            cardInfo.Add(28, new object[] { "7♦", "7", "Diamond", "Diamond7", Properties.Resources._7_of_diamonds, 7 });

            cardInfo.Add(29, new object[] { "8♠", "8", "Spade", "Spade8", Properties.Resources._8_of_spades, 8 });
            cardInfo.Add(30, new object[] { "8♥", "8", "Heart", "Heart8", Properties.Resources._8_of_hearts, 8 });
            cardInfo.Add(31, new object[] { "8♣", "8", "Club", "Club8", Properties.Resources._8_of_clubs, 8 });
            cardInfo.Add(32, new object[] { "8♦", "8", "Diamond", "Diamond8", Properties.Resources._8_of_diamonds, 8 });

            cardInfo.Add(33, new object[] { "9♠", "9", "Spade", "Spade9", Properties.Resources._9_of_spades, 9 });
            cardInfo.Add(34, new object[] { "9♥", "9", "Heart", "Heart9", Properties.Resources._9_of_hearts, 9 });
            cardInfo.Add(35, new object[] { "9♣", "9", "Club", "Club9", Properties.Resources._9_of_clubs, 9});
            cardInfo.Add(36, new object[] { "9♦", "9", "Diamond", "Diamond9", Properties.Resources._9_of_diamonds, 9 });

            cardInfo.Add(37, new object[] { "10♠", "10", "Spade", "Spade10", Properties.Resources._10_of_spades, 10 });
            cardInfo.Add(38, new object[] { "10♥", "10", "Heart", "Heart10", Properties.Resources._10_of_hearts, 10 });
            cardInfo.Add(39, new object[] { "10♣", "10", "Club", "Club10", Properties.Resources._10_of_clubs, 10 });
            cardInfo.Add(40, new object[] { "10♦", "10", "Diamond", "Diamond10", Properties.Resources._10_of_diamonds, 10 });

            cardInfo.Add(41, new object[] { "J♠", "Jack", "Spade", "SpadeJack", Properties.Resources.jack_of_spades, 11 });
            cardInfo.Add(42, new object[] { "J♥", "Jack", "Heart", "HeartJack", Properties.Resources.jack_of_hearts, 11 });
            cardInfo.Add(43, new object[] { "J♣", "Jack", "Club", "ClubJack", Properties.Resources.jack_of_clubs, 11 });
            cardInfo.Add(44, new object[] { "J♦", "Jack", "Diamond", "DiamondJack", Properties.Resources.jack_of_diamonds, 11 });

            cardInfo.Add(45, new object[] { "Q♠", "Queen", "Spade", "SpadeQueen", Properties.Resources.queen_of_spades, 12 });
            cardInfo.Add(46, new object[] { "Q♥", "Queen", "Heart", "HeartQueen", Properties.Resources.queen_of_hearts, 12 });
            cardInfo.Add(47, new object[] { "Q♣", "Queen", "Club", "ClubQueen", Properties.Resources.queen_of_clubs, 12 });
            cardInfo.Add(48, new object[] { "Q♦", "Queen", "Diamond", "DiamondQueen", Properties.Resources.queen_of_diamonds, 12 });

            cardInfo.Add(49, new object[] { "K♠", "King", "Spade", "SpadeKing", Properties.Resources.king_of_spades, 13 });
            cardInfo.Add(50, new object[] { "K♥", "King", "Heart", "HeartKing", Properties.Resources.king_of_hearts, 13 });
            cardInfo.Add(51, new object[] { "K♣", "King", "Club", "ClubKing", Properties.Resources.king_of_clubs, 13 });
            cardInfo.Add(52, new object[] { "K♦", "King", "Diamond", "DiamondKing", Properties.Resources.king_of_diamonds, 13 });

            cardInfo.Add(53, new object[] { "", "JOKER", "", "", Properties.Resources.black_joker, 0 });
            cardInfo.Add(54, new object[] { "", "JOKER", "", "", Properties.Resources.red_joker, 0 });
        }

        void ResetDeck()
        {
            deck.Clear();
            for (int i = 1; i < 53; i++)
            {
                deck.Add(i);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
        }

        void SpawnCard(int specifiedIndex, int targetCard)
        {
            if (deck.Count == 0)
            {
                // empty deck
                return;
            }
            PictureBox targetPB = (PictureBox)Controls.Find("pb_Card" + targetCard, false)[0];
            int rndIndex;
            switch (specifiedIndex)
            {
                case -1:
                    // spawn any from deck, draw from deck
                    rndIndex = r.Next(0, deck.Count);
                    targetPB.Image = (Bitmap)cardInfo[deck[rndIndex]][4];
                    centerCards[targetCard] = new object[] { deck[rndIndex], false };
                    deck.RemoveAt(rndIndex);
                    break;
                case 0:
                    targetPB.Image = (Bitmap)cardInfo[0][4];
                    break;
                default:
                    // spawn specific index, do not draw from deck
                    targetPB.Image = (Bitmap)cardInfo[specifiedIndex][4];
                    break;
            }
        }

        private void b_Start_Click(object sender, EventArgs e)
        {
            if (b_Start.Text == "Start Game") // START GAME
            {
                BackgroundImage = Properties.Resources.BG1;
                b_Start.Text = "New Game";

                userCredits = Convert.ToInt32(nud_StartingAmnt.Value) * 4;
                userWinCredits = 0;
                l_StartingAmnt.Visible = false;
                nud_StartingAmnt.Visible = false;
                if (rb_2Turns.Checked)
                {
                    maxTurns = 2;
                } else
                {
                    maxTurns = 3;
                }
                rb_2Turns.Visible = false; rb_3Turns.Visible = false;
                pb_PointsTable.Image = Properties.Resources.VideoPokerPointsTableCropped;
                pb_Card1.Visible = true; pb_Card2.Visible = true; pb_Card3.Visible = true; pb_Card4.Visible = true; pb_Card5.Visible = true;
                gb_Controls.Visible = true; l_Credit.Visible = true; l_Win.Visible = true; l_CurBet.Visible = true;
                b_LowerBet.Visible = true; b_RaiseBet.Visible = true;
                UpdateCreditLabel(); UpdateWinLabel(); ChangeCurBet(1);
                curTurn = maxTurns; // allow betting at start
            }
            else // NEW GAME
            {
                DialogResult result = MessageBox.Show("Reset and start a new game?", "Video Poker", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    // clear vars, change button name, perform click
                    ResetDeck();
                    curTurn = 1;
                    for (int i = 1; i < 6; i++)
                    {
                        SetHeld(i, false);
                    }
                    b_Start.Text = "Start Game";
                    b_Start.PerformClick();
                }
            }
        }

        void ChangeCurBet(int credits)
        {
            if (credits < 1 || credits > 5) { return; }
            curBetCredits = credits;
            l_CurBet.Text = credits == 1 ? "BET " + credits + " credit" : "BET " + credits + " credits";
            b_LowerBet.Enabled = true; b_RaiseBet.Enabled = true;
            if (credits == 1)
            {
                b_LowerBet.Enabled = false;
            } else if (credits == 5)
            {
                b_RaiseBet.Enabled = false;
            }
        }

        void Deal()
        {
            dealing = true;
            nonHeldCards = new List<int>();
            for (int i = 1; i < 6; i++)
            {
                if ((bool)centerCards[i][1] == false)
                {
                    nonHeldCards.Add(i);
                }
            }
            foreach (int card in nonHeldCards)
            {
                SpawnCard(0, card);
            }
            t_Deal.Start();
        }

        void SetHeld(int targetCard, bool held)
        {
            centerCards[targetCard] = new object[] { centerCards[targetCard][0], held };
            Label targetL = (Label)Controls.Find("l_Held" + targetCard, false)[0];
            targetL.Visible = held;
        }

        void UpdateCreditLabel()
        {
            decimal amnt = Convert.ToDecimal(Decimal.Divide(userCredits, 4).ToString("0.00"));
            l_Credit.Text = "CREDIT\n" + userCredits + " credits\n$" + amnt.ToString();
        }

        void UpdateWinLabel()
        {
            decimal amnt = Convert.ToDecimal(Decimal.Divide(userWinCredits, 4).ToString("0.00"));
            l_Win.Text = "WIN\n" + userWinCredits + " credits\n$" + amnt.ToString();
        }

        private void b_LowerBet_Click(object sender, EventArgs e)
        {
            ChangeCurBet(curBetCredits - 1);
        }

        private void b_RaiseBet_Click(object sender, EventArgs e)
        {
            ChangeCurBet(curBetCredits + 1);
        }

        private void CenterCardsPB_Click(object sender, EventArgs e)
        {
            PictureBox pBox = (PictureBox)sender;
            int centerCardNum = Convert.ToInt32(pBox.Name.Substring(pBox.Name.Length - 1, 1));
            if (dealing || (int)centerCards[centerCardNum][0] == 0 || curTurn == maxTurns) { return; } // do not allow holding
            SetHeld(centerCardNum, !((bool)centerCards[centerCardNum][1]));
        }

        private void t_Deal_Tick(object sender, EventArgs e)
        {
            // deal new card to each spot NOT held
            if (nonHeldCards.Count == 0)
            {
                timerCurIndex = -1;
                curTurn = maxTurns;
            } else
            {
                SpawnCard(-1, nonHeldCards[timerCurIndex]);
            }
            if (timerCurIndex == nonHeldCards.Count - 1)
            {
                timerCurIndex = 0;
                if (curTurn == maxTurns)
                {
                    object[] curHand = GetPokerHand();
                    if ((string)curHand[1] != "")
                    {
                        l_Hand.Text = curHand[1].ToString().ToUpper() + " +" + curHand[0].ToString();
                        t_ShowHand.Start();
                        userWinCredits += (int)curHand[0];
                        UpdateWinLabel();
                        userCredits += (int)curHand[0];
                        UpdateCreditLabel();
                    }
                    b_LowerBet.Visible = true;
                    b_RaiseBet.Visible = true;
                }
                dealing = false;
                b_Deal.Enabled = true;
                t_Deal.Stop();
            } else { timerCurIndex++; }
        }

        private void b_Deal_Click(object sender, EventArgs e)
        {
            // deal to cards that are not held, keep track of turns, on last turn check for hands made and add points
            if (dealing) { return; }
            if (curTurn == maxTurns)
            {
                b_LowerBet.Visible = false;
                b_RaiseBet.Visible = false;
                ResetDeck();
                curTurn = 1;
                for (int i = 1; i < 6; i++)
                {
                    SetHeld(i, false);
                }
                userCredits -= curBetCredits;
                UpdateCreditLabel();
            } else { curTurn++; }
            b_Deal.Enabled = false;
            Deal();
        }

        private void t_ShowHand_Tick(object sender, EventArgs e)
        {
            switch (animationTimerStep)
            {
                case 0:
                    l_Hand.Visible = true;
                    t_ShowHand.Interval = 300;
                    break;
                case 1:
                    l_Hand.Visible = false;
                    t_ShowHand.Interval = 100;
                    break;
                case 2:
                    l_Hand.Visible = true;
                    t_ShowHand.Interval = 300;
                    break;
                case 3:
                    l_Hand.Visible = false;
                    t_ShowHand.Interval = 100;
                    animationTimerStep = 0;
                    t_ShowHand.Stop();
                    break;
            }
            animationTimerStep++;
        }

        object[] GetPokerHand() // indices: 0 = hand value, 1 = hand name
        {
            // check for hand in descending order, return earned credits
            List<int> centerOrdering = new List<int>() { (int)cardInfo[(int)centerCards[1][0]][5], (int)cardInfo[(int)centerCards[2][0]][5], (int)cardInfo[(int)centerCards[3][0]][5],
                (int)cardInfo[(int)centerCards[4][0]][5], (int)cardInfo[(int)centerCards[5][0]][5] };
            bool isStraight = false;
            bool isFlush = false;
            int repeatVal1, repeatVal2 = 0;
            int repeatCnt1, repeatCnt2 = 0;
            centerOrdering.Sort();

            string firstSuit = (string)cardInfo[(int)centerCards[1][0]][2];
            for (int i = 2; i < 6; i++)
            {
                if ((string)cardInfo[(int)centerCards[i][0]][2] == firstSuit)
                {
                    if (i == 5) { isFlush = true; }
                }
                else { isFlush = false; break; }
            }
            for (int i = 0; i < 4; i++)
            {
                if ((centerOrdering[i + 1] == centerOrdering[i] + 1))
                {
                    if (i == 3) { isStraight = true; }
                }
                else { isStraight = false; break; }
            }
            isStraight = isStraight || EqualsAll(centerOrdering, specialStraightOrder);

            // ROYAL FLUSH ?
            if (isStraight && isFlush && EqualsAll(centerOrdering, specialStraightOrder))
            {
                return new object[] { ROYALFLUSH_PTS[curBetCredits], "Royal Flush" };
            }

            // STRAIGHT FLUSH ?
            if (isStraight && isFlush)
            {
                return new object[] { STRAIGHT_PTS[curBetCredits], "Straight Flush" };
            }

            // 4 OF A KIND ?
            repeatVal1 = centerOrdering[0];
            repeatCnt1 = 0;
            for (int i = 1; i < 5; i++)
            {
                if (centerOrdering[i] == repeatVal1)
                {
                    repeatCnt1++;
                    if (repeatCnt1 >= 3) { break; }
                } else
                {
                    repeatCnt1 = 0;
                    repeatVal1 = centerOrdering[i];
                }
            }
            if (repeatCnt1 == 3)
            {
                return new object[] { FOUROFAKIND_PTS[curBetCredits], "4 Of A Kind" };
            }
            repeatVal1 = 0; repeatCnt1 = 0;

            // FULL HOUSE ? / TWO PAIR ?
            bool scanning2ndValue = false;
            repeatVal1 = centerOrdering[0];
            for (int i = 1; i < 5; i++)
            {
                if (!scanning2ndValue)
                {
                    if (centerOrdering[i] == repeatVal1)
                    {
                        repeatCnt1++;
                    }
                    else
                    {
                        if (repeatCnt1 == 1 || repeatCnt1 == 2)
                        {
                            repeatVal2 = centerOrdering[i];
                            scanning2ndValue = true;
                        } else
                        {
                            repeatCnt1 = 0;
                            repeatVal1 = centerOrdering[i];
                        }
                    }
                }
                else
                {
                    if (centerOrdering[i] == repeatVal2)
                    {
                        repeatCnt2++;
                        //if (repeatCnt2 == 1 || repeatCnt2 == 2) { break; }
                    }
                    else
                    {
                        //repeatCnt2 = 0;
                        repeatVal2 = centerOrdering[i];
                    }
                }
            }
            if ((repeatCnt1 == 1 && repeatCnt2 == 2) || (repeatCnt1 == 2 && repeatCnt2 == 1))
            {
                return new object[] { FULLHOUSE_PTS[curBetCredits], "Full House" };
            }
            if (repeatCnt1 == 1 && repeatCnt2 == 1 && !isFlush && !isStraight)
            {
                return new object[] { TWOPAIR_PTS[curBetCredits], "Two Pair" };
            }
            repeatVal1 = 0; repeatCnt1 = 0; repeatVal2 = 0; repeatCnt2 = 0;

            // 3 OF A KIND ?
            repeatVal1 = centerOrdering[0];
            repeatCnt1 = 0;
            for (int i = 1; i < 5; i++)
            {
                if (centerOrdering[i] == repeatVal1)
                {
                    repeatCnt1++;
                    if (repeatCnt1 >= 2) { break; }
                }
                else
                {
                    repeatCnt1 = 0;
                    repeatVal1 = centerOrdering[i];
                }
            }
            if (repeatCnt1 == 2 && !isFlush)
            {
                return new object[] { THREEOFAKIND_PTS[curBetCredits], "3 Of A Kind" };
            }
            repeatVal1 = 0; repeatCnt1 = 0;

            // FLUSH ?
            if (isFlush)
            {
                return new object[] { FLUSH_PTS[curBetCredits], "Flush" };
            }

            // STRAIGHT ?
            if (isStraight)
            {
                return new object[] { STRAIGHT_PTS[curBetCredits], "Straight" };
            }

            // PAIR ?
            repeatVal1 = centerOrdering[0];
            for (int i = 1; i < 5; i++)
            {
                if (centerOrdering[i] == repeatVal1)
                {
                    repeatCnt1++;
                    break;
                }
                else
                {
                    repeatCnt1 = 0;
                    repeatVal1 = centerOrdering[i];
                }
            }
            if (repeatCnt1 == 1 && (repeatVal1 == 1 || repeatVal1 > 10))
            {
                return new object[] { PAIR_PTS[curBetCredits], "Pair" };
            }
            repeatVal1 = 0; repeatCnt1 = 0;

            return new object[] { 0, "" };
        }

        bool EqualsAll<T>(IList<T> a, IList<T> b)
        {
            if (a == null || b == null)
                return (a == null && b == null);

            if (a.Count != b.Count)
                return false;

            return a.SequenceEqual(b);
        }
    }
}
