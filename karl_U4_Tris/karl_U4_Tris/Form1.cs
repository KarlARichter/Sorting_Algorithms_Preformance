/***************************************************************
*Karl Richter
*École Secondaire Catholique Renaissance
*ICS4U, 2022-23
*
*Dernier Modification: 12-12-2022
*
*DESCRIPTION
*Cette programme génere une liste de nombre avec une longeur définit par l'utilisateur et 
*utilise 6 algorithmes de triages pour trier la liste et l'afficher. De plus on calcule le 
*temps d'execution de chaque algorithme et on crée une liste qui affiche les algorithmes 
*de plus vite au plus lent. Ce programme contient aussi une fonction "preformance" qui 
*crée une liste de 5000 puis execute chauque bouton automatiquement.
*
*
*HYPOTHÈSES:
*L'utilisateur execute le code correctement 
*
*
***************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using TextBox = System.Windows.Forms.TextBox;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Linq.Expressions;
using System.IO;


namespace U4_Algorithmes_Squelette
{
    public partial class Form1 : Form
    {
        //Ici on declare tous les variables public qui
        //sont utiliser a travers le projet 
        public int[] values;
        public int r,l;
        public bool click1,click2,click3,click4,click5,click6;

        public Form1()
        {
            InitializeComponent();
        }

        //Cette method exchange nous permet de deplacer les nombres quand on fait le triage
        public static void exchange(int[] values, int x, int y)
        {
            int temporary;

            temporary = values[x];
            values[x] = values[y];
            values[y] = temporary;
        }

        //Cette method crée la liste de nombre
        private void RndArray(object sender, EventArgs e)
        {
            //Cette fonction try catch assure que l'utilisateur peut seulement
            //entrer des nombres et non pas des lettres out des symboles
            try
            {
                Regex regex = new Regex("^[a-zA-Z]+$");
                bool hasOnlyAlpha = regex.IsMatch(textBox_arrayLength.Text);
                if (hasOnlyAlpha == true)
                {
                    throw new Exception();
                }
                //Si l'utilisateur entre des nombres come il le faux:
                else
                {
                    //On crée une liste a partir des nombres entrer par l'utilisateur
                    textBox_unsortedArray.Clear();
                    int count = int.Parse(textBox_arrayLength.Text);
                    values = new int[count];

                    Random rnd = new Random();
                    TextBox boxing = textBox_unsortedArray;

                    for (int i = 0; i < values.Length; ++i)
                    {
                        values[i] = rnd.Next(0, count + 1);
                        boxing.Text = boxing.Text + values[i].ToString() + " ";
                    }
                    btn_newRandomArray.ForeColor = Color.Green;
                    textBox_maxValue.Text = textBox_arrayLength.Text;
                }
            }
            catch (Exception ex)
            {
                var result = MessageBox.Show("SVP entrer un nombre et non pas une letter",
                               "ERREUR: Entrée de données incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Cette method contient le code pour la fonction Array.Sort()
        private void ArraySort(object sender, EventArgs e)
        {
            try
            {
                if (values == null)
                {
                    throw new Exception();
                }

                //Ici (come dans tous les methods) on utilise une
                //stopwatch pour mesurer le temps que chaque algorithme prends
                var watch = new Stopwatch();
                watch.Start();
                Array.Sort(values);
                watch.Stop();
                btn_Default.ForeColor = Color.Green;

                //Ceci affiche les nombres en ordre dans le textbox sortedarray
                textBox_sortedArray.Clear();
                foreach (int value in values)
                {
                    textBox_sortedArray.Text = textBox_sortedArray.Text + " " + value.ToString();
                }
                textBox_Default.Text = String.Format($"{watch.Elapsed.TotalMilliseconds:0.0000}");
            }
            catch (Exception ex)
            {
                var result = MessageBox.Show("SVP générer un tableau avant de trier",
                               "ERREUR: Tableau non trié", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            click1 = true;
        }
        
        //Ceci contient le code pour le fonctionnement de l'algorithme bubbleSort
        private void BubbleSort(object sender, EventArgs e)
        {
            try
            {
                if (values == null)
                {
                    throw new Exception();
                }
                
                //On commence le stopwatch
                var watch = new Stopwatch();
                watch.Start();
                
                int i, j;
                int N = values.Length;

                //On execute l'algorithme
                for (j = N - 1; j > 0; j--)
                {
                    for (i = 0; i < j; i++)
                    {
                        if (values[i] > values[i + 1])
                            exchange(values, i, i + 1);
                    }
                }
                btn_Bubble.ForeColor = Color.Green;
                watch.Stop();

                //Puis on affiche les nombres en ordre
                textBox_sortedArray.Clear();
                foreach (int value in values)
                {
                    textBox_sortedArray.Text = textBox_sortedArray.Text + " " + value.ToString();
                }
                textBox_Bubble.Text = String.Format($"{watch.Elapsed.TotalMilliseconds:0.0000}");
            }
            catch (Exception ex)
            {
                var result = MessageBox.Show("SVP générer un tableau avant de trier",
                               "ERREUR:Tableau non trié", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            click2 = true;
        }

        //Ceci fait partie de l'algorithme Selection sort
        public static int IntArrayMinSelection(int[] values, int start)
        {
            int minPos = start;
            for (int pos = start + 1; pos < values.Length; pos++)
                if (values[pos] < values[minPos])
                    minPos = pos;
            return minPos;
        }

        //Ceci est le main code pour selection sort
        private void SelectionSort(object sender, EventArgs e)
        {
            // Vérifier si un tableau a été généré
            if (values == null)
            {
                // Si aucun tableau n'a été généré, lever une exception
                throw new Exception();
            }

            // Créer un nouveau chronomètre
            var watch = new Stopwatch();
            watch.Start();

            int i;
            int N = values.Length;

            // Tri par sélection
            for (i = 0; i < N - 1; i++)
            {
                // Trouver le minimum dans le sous-tableau non trié
                int k = IntArrayMinSelection(values, i);

                // Échanger les éléments si nécessaire
                if (i != k)
                    exchange(values, i, k);
            }

            // Mettre le texte du bouton en vert
            btn_Selection.ForeColor = Color.Green;

            // Arrêter le chronomètre
            watch.Stop();

            // Afficher le tableau trié
            textBox_sortedArray.Clear();
            foreach (int value in values)
            {
                textBox_sortedArray.Text = textBox_sortedArray.Text + " " + value.ToString();
            }

            // Afficher le temps d'exécution de l'algorithme
            textBox_Selection.Text = String.Format($"{watch.Elapsed.TotalMilliseconds:0.0000}");

            // Indiquer que l'algorithme a été exécuté
            click3 = true;
        }

        private void InsertionSort(object sender, EventArgs e)
        {
            try
            {
                if (values == null)
                {
                    // Si les valeurs sont null, lancer une exception
                    throw new Exception();
                }

                // Démarrer un chronomètre
                var watch = new Stopwatch();
                watch.Start();

                int i, j;
                int N = values.Length;

                // Pour chaque élément dans les valeurs
                for (j = 1; j < N; j++)
                {
                    // Pour chaque élément avant l'élément actuel
                    for (i = j; i > 0 && values[i] < values[i - 1]; i--)
                    {
                        // Si l'élément actuel est plus petit que l'élément précédent, les échanger de place
                        exchange(values, i, i - 1);
                    }
                }

                // Arrêter le chronomètre
                watch.Stop();

                // Mettre le texte du bouton en vert
                btn_Insertion.ForeColor = Color.Green;

                // Effacer le contenu de la boîte de texte
                textBox_sortedArray.Clear();

                // Pour chaque valeur dans les valeurs triées
                foreach (int value in values)
                {
                    // Ajouter la valeur à la boîte de texte
                    textBox_sortedArray.Text = textBox_sortedArray.Text + " " + value.ToString();
                }

                // Afficher le temps écoulé dans la boîte de texte
                textBox_Insertion.Text = String.Format($"{watch.Elapsed.TotalMilliseconds:0.0000}");
            }
            catch (Exception ex)
            {
                // Si une exception est lancée, afficher un message d'erreur
                var result = MessageBox.Show("SVP générer un tableau avant de trier",
                                "ERREUR: Tableau non trié", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Activer le clic
            click4 = true;
        }

        private void MergeSort(object sender, EventArgs e)
        {
            try
            {
                if (values == null)
                {
                    // Si les valeurs sont null, lancer une exception
                    throw new Exception();
                }

                // Démarrer un chronomètre
                var watch = new Stopwatch();
                watch.Start();

                // Trier les valeurs
                MergeSort(values, 0, values.Length - 1);

                watch.Stop();
                btn_Merge.ForeColor = Color.Green;
                textBox_sortedArray.Clear();

                // Pour chaque valeur dans les valeurs triées
                foreach (int value in values)
                {
                    // Ajouter la valeur à la boîte de texte
                    textBox_sortedArray.Text = textBox_sortedArray.Text + " " + value.ToString();
                }

                // Afficher le temps écoulé dans la boîte de texte
                textBox_Merge.Text = String.Format($"{watch.Elapsed.TotalMilliseconds:0.0000}");
            }
            catch (Exception ex)
            {
                // Si une exception est lancée, afficher un message d'erreur
                var result = MessageBox.Show("SVP générer un tableau avant de trier",
                                "ERREUR: Tableau non trié", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Activer le clic
            click5 = true;
        }

        private void Merge(int[] input, int left, int middle, int right)
        {
            // Déclarer les tableaux gauche et droit
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            // Copier les éléments des tableaux d'entrée dans les tableaux gauche et droit
            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            // Initialiser les compteurs pour les tableaux gauche et droit
            int i = 0;
            int j = 0;

            // Pour chaque élément dans l'intervalle entre la valeur de gauche et de droite
            for (int k = left; k < right + 1; k++)
            {
                // Si tous les éléments du tableau gauche ont été utilisés
                if (i == leftArray.Length)
                {
                    // Prendre l'élément du tableau droit
                    input[k] = rightArray[j];
                    j++;
                }
                // Si tous les éléments du tableau droit ont été utilisés
                else if (j == rightArray.Length)
                {
                    // Prendre l'élément du tableau gauche
                    input[k] = leftArray[i];
                    i++;
                }
                // Si l'élément du tableau gauche est inférieur ou égal à l'élément du tableau droit
                else if (leftArray[i] <= rightArray[j])
                {
                    // Prendre l'élément du tableau gauche
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    // Prendre l'élément du tableau droit
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }

        private void MergeSort(int[] input, int left, int right)
        {
            // Si le nombre d'éléments à trier est supérieur à 1
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(input, left, middle);

                MergeSort(input, middle + 1, right);

                Merge(input, left, middle, right);
            }
        }

        private void QuickSort(object sender, EventArgs e)
        {
            try
            {
                if (values == null)
                {
                    // Si les valeurs sont null, lancer une exception
                    throw new Exception();
                }

                // Démarrer un chronomètre
                var watch = new Stopwatch();
                watch.Start();

                // Trier les valeurs
                IntArrayQuickSort(values, 0, values.Length - 1);

                watch.Stop();

                btn_Quick.ForeColor = Color.Green;
                textBox_sortedArray.Clear();

                // Pour chaque valeur dans les valeurs triées
                foreach (int value in values)
                {
                    // Ajouter la valeur à la boîte de texte
                    textBox_sortedArray.Text = textBox_sortedArray.Text + " " + value.ToString();
                }

                // Afficher le temps écoulé dans la boîte de texte
                textBox_Quick.Text = String.Format($"{watch.Elapsed.TotalMilliseconds:0.0000}");
            }
            catch (Exception ex)
            {
                // Si une exception est lancée, afficher un message d'erreur
                var result = MessageBox.Show("SVP générer un tableau avant de trier",
                                "ERREUR: Tableau non trié", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Activer le clic
            click6 = true;
        }

        public void IntArrayQuickSort(int[] values, int l, int r)
        {
            int i, j;
            int x;
            i = l;
            j = r;
            x = values[(l + r) / 2];

            // Tant que la boucle n'est pas terminée
            while (true)
            {
                // Si l'élément de gauche est inférieur à la valeur pivot, passer à l'élément suivant
                while (values[i] < x)
                    i++;

                // Si l'élément de droite est supérieur à la valeur pivot, passer à l'élément précédent
                while (x < values[j])
                    j--;

                // Si l'élément de gauche est inférieur ou égal à l'élément de droite
                if (i <= j)
                {
                    // Échanger les éléments
                    exchange(values, i, j);

                    // Passer à l'élément suivant pour les deux compteurs
                    i++;
                    j--;
                }

                // Si l'élément de gauche est supérieur à l'élément de droite, arrêter la boucle
                if (i > j)
                    break;
            }

            // Si l'élément de gauche est inférieur au pivot, trier l'intervalle de gauche
            if (l < j)
                IntArrayQuickSort(values, l, j);

            // Si l'élément de droite est supérieur au pivot, trier l'intervalle de droite
            if (i < r)
                IntArrayQuickSort(values, i, r);
        }

        private void performanceClick(object sender, EventArgs e)
        {

            btn_performance.ForeColor = Color.Green;
            btn_trierTout.ForeColor = Color.Green;

            // Définir la longueur du tableau
            textBox_arrayLength.Text = "5000";


            textBox_unsortedArray.Clear();
            int count = int.Parse(textBox_arrayLength.Text);
            values = new int[count];

            Random rnd = new Random();
            TextBox boxing = textBox_unsortedArray;

            for (int i = 0; i < values.Length; ++i)
            {
                values[i] = rnd.Next(0, count + 1);
                boxing.Text = boxing.Text + values[i].ToString() + " ";
            }
            btn_newRandomArray.ForeColor = Color.Green;
            textBox_maxValue.Text = textBox_arrayLength.Text;

            // Définir la valeur maximale

            btn_Bubble.PerformClick();
            btn_Default.PerformClick();
            btn_Insertion.PerformClick();
            btn_Selection.PerformClick();
            btn_Merge.PerformClick();
            btn_Quick.PerformClick();
            btn_compare.PerformClick();
        }

        private void compareArray(object sender, EventArgs e)
        {
            // Vérifier si tous les algorithmes de tri ont été exécutés
            if (click1 && click2 && click3 && click4 && click5 && click6)
            {
                // Mettre le texte des boutons en vert
                btn_compare.ForeColor = Color.Green;
                btn_newRandomArray.ForeColor = Color.Green;

                // Créer un tableau contenant les temps d'exécution des algorithmes de tri et leurs noms respectifs
                string[,] arraySpeed = new string[6, 2] { { textBox_Default.Text, "Array.Sort" }, { textBox_Bubble.Text, "Bubble Sort" }, { textBox_Selection.Text, "Selection Sort" }, { textBox_Insertion.Text, "Insertion Sort" }, { textBox_Merge.Text, "Merge Sort" }, { textBox_Quick.Text, "Quick Sort" } };

                // Créer un tableau contenant les temps d'exécution des algorithmes de tri
                string[] speedSorted = new string[] { textBox_Default.Text, textBox_Bubble.Text, textBox_Selection.Text, textBox_Insertion.Text, textBox_Merge.Text, textBox_Quick.Text };

                // Trier les temps d'exécution
                Array.Sort(speedSorted);

                // Créer un tableau temporaire pour stocker les noms des algorithmes de tri triés par temps d'exécution
                string[] temp = new string[6];

                // Pour chaque temps d'exécution
                for (int i = 0; i < 6; i++)
                {
                    // Pour chaque algorithme de tri
                    for (int j = 0; j < 6; j++)
                    {
                        // Si le temps d'exécution actuel est celui de l'algorithme actuel
                        if (speedSorted[i] == arraySpeed[j, 0])
                        {
                            // Ajouter le nom de l'algorithme au tableau temporaire
                            temp[i] = arraySpeed[j, 1];
                            break;
                        }
                    }
                }

                // Afficher les algorithmes triés par temps d'exécution dans les boîtes de texte
                textBox1.Text = temp[0];
                textBox2.Text = temp[1];
                textBox3.Text = temp[2];
                textBox4.Text = temp[3];
                textBox5.Text = temp[4];
                textBox6.Text = temp[5];
            }
            // Si tous les algorithmes de tri n'ont pas été exécutés
            else
            {
                var results = MessageBox.Show("SVP exécuter tous les algorithmes de tri avant de les trier.",
                               "ERREUR: Données manquantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TrierTout(object sender, EventArgs e)
        {
            try
            {
                // Vérifier si un tableau a été généré
                if (values == null)
                {
                    // Si aucun tableau n'a été généré, lever une exception
                    throw new Exception();
                }

                // Mettre le texte du bouton en vert
                btn_trierTout.ForeColor = Color.Green;

                // Exécuter tous les algorithmes de tri
                btn_Bubble.PerformClick();
                btn_Default.PerformClick();
                btn_Insertion.PerformClick();
                btn_Selection.PerformClick();
                btn_Merge.PerformClick();
                btn_Quick.PerformClick();
            }
            catch (Exception ex)
            {
                var result = MessageBox.Show("SVP générer un tableau avant de trier",
                               "ERREUR: Tableau non trié", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        //Cette method decris les informations pour array.sort
        private void ArraySortINFO(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Array. Sort() choisit l'un des trois algorithmes de tri, en fonction de la taille de l'entrée : Si la taille est inférieure à 16 éléments, elle utilise un algorithme de tri par insertion. Si la taille dépasse 2 * log^N , où N est l'étendue du tableau d'entrée, elle utilise un algorithme de tri par tas." ,

                                "Informations Array Sort", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Cette method decris les informations pour bubble sort
        private void BubbleSortINFO(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Le tri à bulles est de loin le plus simple de tous les algos de tri. D’ailleurs c’est pour ça qu’il est super lent et quasiment jamais utilisé. \n\n" +
                                "-On passe sur chaque élément du tableau et on le compare à son voisin de droite.\n" +
                                "-Si le voisin de droite est plus petit alors les deux éléments permutent (changent de place), car l’élément le plus petit devrait être à gauche. \n" +
                                "-On fait autant de passe que nécessaire jusqu’à que tout le tableau soit trié.",

                                "Informations Bubble Sort", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Cette method decris les informations pour Selection sort
        private void SelectionSortINFO(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Cet algorithme est intuitif. D’abord, il cherche l’élément le plus petit du tableau. Puis, il échange cet élément avec l’élément en première place du tableau. Enfin, il réitère ces actions jusqu’à ce que le tableau soit entièrement trié. \n\n" +
                               "La complexité du tri par sélection est en O(n²). Il n’est donc pas très efficace. Mais, il fait très peu d’échanges (au maximum, n-1). Donc, il peut être utilisé si les éléments sont coûteux à déplacer (ce qui n’est pas le cas d’un tableau d’entier) et peu coûteux à comparer. \n" ,

                               "Informations Selection Sort", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        //Cette method decris les informations pour Insertions sort
        private void InsertionSortINFO(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Le tri par insertion fait également partie des algorithmes de tri les plus simples à comprendre et à utiliser. Et comme souvent, sa simplicité vient avec le prix d’une mauvaise performance sur de larges séquences de données. C’est un algorithme assez lent avec beaucoup de données, mais efficace avec peu de données.\n\n" +
                               "La logique de cet algorithme est intuitive: \n\n" +
                               "-On passe sur chacun des éléments à trier et on l’insère directement à la place où il devrait être.\n"+
                               "-Pour faire cette insertion, on va simplement comparer l’élément courant avec chaque élément déjà trié sur la gauche." ,


                               "Informations Insertion Sort", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Cette method decris les informations pour 
        private void MergeSortINFO(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Le tri fusion est un algorithme de la grande famille des algorithmes « diviser pour régner » (divide and conquer). Il est légèrement plus complexe que les algorithmes précédents, mais son efficacité est redoutable ! En particulier sur de grandes séquences de données!\n\n" +
                                        "Cet algorithme de tri a une logique un peu plus complexe:\n" +
                                        "-On va commencer par diviser le tableau en deux éléments égaux.\n"+
                                        "-On va recommencer la même chose jusqu’à atteindre un seul élément par séparation.\n" +
                                        "-Ensuite, on va refusionner les éléments séparés de façon récursive en les triant à chaque niveau.\n\n" +
                                        "Cet algorithme étant un algorithme de la famille « diviser pour régner » (divide and conquer) on est sur une complexité linéarithmique O(n log n) dans le pire cas ! Ça fait de cet algorithme de tri l’un des plus optimisés, et donc l’un des plus utilisés." ,

                                         "Informations Merge Sort", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Cette method decris les informations pour Quick Sort
        private void QuickSortINFO(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Le tri rapide (quicksort) fait aussi partie de la famille des algorithmes « diviser pour régner ». Lui aussi utilise donc de la récursivité et sa logique est un peu plus complexe. Son fonctionnement est centré autour du concept du pivot.\n\n" +
                                        "On va choisir un élément dans le tableau et on va décréter que cet élément est le pivot pour une itération sur le tableau. Il y a différentes façons de choisir un pivot. Disons que le pivot sera toujours le dernier élément du tableau.\n\n" +
                                        "Une fois qu’on a ce pivot, on va créer un sous-tableau.\n" +
                                        "-Toutes les valeurs plus basses que ce pivot vont à gauche de ce sous-tableau.\n" +
                                        "-Le pivot au milieu de ce sous-tableau.\n" +
                                        "Toutes les valeurs plus grandes que ce pivot vont à droite.\n\n" +
                                        "La complexité moyenne du tri rapide est optimale avec une complexité linéarithmique O(n log n).",


                                         "Informations Quick Sort", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Cette method decris les informations pour le bouton HELP
        private void helpINFO(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Projet karl_U4_Tris\n" +
                                       "Écrit par Karl Richter\n" +
                                       "ÉSC Renaissance, ISC4U, Unité 4\n" +
                                       "Dernière modification: Decembre 12\n" +
                                       "\r\n\r\nCe programme permet à l'utilisateur d'explorer et de comparer la performance de divers algorithmes de tri.\n" ,


                                        "Projet karl_U4_Tris", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Cette method reset tous les informations dans le form et le recommence
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        //Cette method quitte l'application
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_unsortedArray_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

