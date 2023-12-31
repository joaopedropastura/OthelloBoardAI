// public class Node
// {
<<<<<<< HEAD
//     public OthelloBoard State { get; set; }
=======
//     public Othello State { get; set; }
>>>>>>> 0382aec0ff575987e209c06ef19a97006c4eb0e9
//     public float Avaliation { get; set; } = 0;
//     public List<Node> Children { get; set; } = new();
//     public bool Expanded { get; set; } = false;
//     public bool YouPlays { get; set; } = true;
//     public float AlphaBeta() => AlphaBeta(float.NegativeInfinity, float.PositiveInfinity);

//     public Node Play(int board, int position)
//     {
//         foreach (var child in Children)
//         {
//             var last = child.State.GetLast();
//             if (last.board == board && last.position == position)
//                 return child;
//         }
//         return null;
//     }

//     public void Expand(int deep)
//     {
//         if (deep == 0)
//             return;
        
//         if (!this.Expanded)
//         {
//             var nexts = this.State.Next();
//             foreach (var next in nexts)
//                 this.Children.Add(new Node()
//                 {
//                     State = next,
//                     YouPlays = !YouPlays
//                 });
//             this.Expanded = true;
//         }

//         foreach (var child in this.Children)
//             child.Expand(deep - 1);
//     }

//     public Node PlayBest()
//     {
//         return Children.MaxBy(n => 
//             YouPlays ? n.Avaliation : -n.Avaliation
//         );
//     }

//     public float AlphaBeta(float alpha, float beta)
//     {
//         if (this.Children.Count == 0)
//         {
//             this.Avaliation = aval();
//             return this.Avaliation;
//         }

//         if (YouPlays)
//         {
//             var value = float.NegativeInfinity;
//             foreach (var child in Children)
//             {
//                 value = Math.Max(value, child.AlphaBeta(alpha, beta));
//                 if (beta < value)
//                     break;
//             }
//             alpha = Math.Max(value, alpha);
//             return value;
//         }
//         else
//         {
//             var value = float.PositiveInfinity;
//             foreach (var child in Children)
//             {
//                 value = Math.Min(value, child.AlphaBeta(alpha, beta));
//                 if (alpha > value)
//                     break;
//             }
//             beta = Math.Min(value, beta);
//             return value;
//         }
//     }

//     private float aval()
//     {
//         if (State.GameEnded())
//             return YouPlays ? float.PositiveInfinity : float.NegativeInfinity;
        
//         return Random.Shared.NextSingle();
//     }
// }