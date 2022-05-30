using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace W14_JY_070602210044
{
    public partial class teamForm : Form
    {
        public teamForm()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        public int counter2 = 0;
        string sqlQuery;
        DataTable team = new DataTable();
        DataTable topScorer = new DataTable();
        DataTable worstDiscipline = new DataTable();
        DataTable lastMatch = new DataTable();

        private void btn_First_Click(object sender, EventArgs e)
        {
            counter2 = 0;
            Match(counter2);
            MessageBox.Show("Data Sudah Data Pertama");
        }
        private void btn_Prev_Click(object sender, EventArgs e)
        {
            counter2--;
            Match(counter2);
        }
        private void btn_Next_Click(object sender, EventArgs e)
        {
            counter2++;
            Match(counter2);
        }
        private void btn_Last_Click(object sender, EventArgs e)
        {
            counter2 = team.Rows.Count - 1;
            Match(counter2);
            MessageBox.Show("Data Sudah Data Terakhir");
        }
        private void teamForm_Load(object sender, EventArgs e)
        { 
            sqlQuery = "select t.team_name as `Team Name`, concat(m.manager_name, ', ', n.nation) as `Manager Name`," +
                " concat(t.home_stadium,', ', t.city, ' (', t.capacity, ')') as `Stadium`, t.team_id from team t," +
                " manager m, dmatch dm, nationality n where t.manager_id = m.manager_id and m.nationality_id = n.nationality_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(team);

            sqlQuery = "select p.player_name as Player, goal.Goal + penalty.Penalty as Goal," +
                " penalty.Penalty as Penalty from player p, (select d.player_id as id, sum(if(d.type = 'GO', 1, 0)) as Goal from dmatch d group by 1) goal," +
                " (select d.player_id as id, sum(if(d.type = 'GP', 1, 0)) as Penalty from dmatch d group by 1) penalty" +
                " where p.player_id = goal.id and goal.id = penalty.id and p.team_id = 'A001' order by 2 desc";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(topScorer);

            sqlQuery = "select p.player_name as `Player`, Kuning.poin + Merah.poin as `Point`, Kuning.Yellow as `Yellow Card`, Merah.Red as `Red Card` " +
                "from player p, (select dm.player_id as `ID`, sum(if(dm.type = 'CY', 1, 0)) as Yellow, sum(if(dm.type='CY', 1, 0)) as poin from dmatch dm group by 1) `Kuning`," +
                " (select dm.player_id as `ID`, sum(if(dm.type = 'CR', 1, 0)) as Red, sum(if(dm.type = 'CR', 3, 0)) as poin from dmatch dm group by 1) `Merah` " +
                "where p.player_id = Kuning.ID and Kuning.ID = Merah.ID and p.team_id = 'A001' order by 2 desc";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(worstDiscipline);

            sqlQuery = "select match_date as `match date`, date_format(m.match_date, \"%d/%c/%Y\") as `Match Date`," +
                " 'HOME' as `Home/Away`, concat('vs ', t.team_name) as `Lawan`, concat(m.goal_home, ' - ', m.goal_away) as `Score` from `match` m, team t where m.team_home = 'A001' and m.team_away = t.team_id union select match_date, date_format(m.match_date, \"%d/%c/%Y\") as `Match Date`, 'AWAY' as 'Home/Away', concat('vs ', t.team_name) as `Lawan`, concat(m.goal_home, ' - ', m.goal_away) as `Score` " +
                "from `match` m, team t " +
                "where m.team_away = 'A001' and m.team_home = t.team_id order by 1 desc limit 0, 5;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(lastMatch);
            dgvMatch.DataSource = lastMatch;
            dgvMatch.Columns.RemoveAt(0);
            Match(counter2);
        }
        private void Match(int counter1)
        {
            LblTeam.Text = team.Rows[counter1][0].ToString();
            LblManager.Text = team.Rows[counter1][1].ToString();
            LblStadium.Text = team.Rows[counter1][2].ToString();
            topScorer = new DataTable();
            sqlQuery = "select p.player_name as Player, goal.Goal + penalty.Penalty as Goal, penalty.Penalty as Penalty from player p, (select d.player_id as id, sum(if(d.type = 'GO', 1, 0)) as Goal from dmatch d group by 1) goal, (select d.player_id as id, sum(if(d.type = 'GP', 1, 0)) as Penalty from dmatch d group by 1) penalty where p.player_id = goal.id and goal.id = penalty.id and p.team_id = '" + team.Rows[counter1][3].ToString() + "' order by 2 desc";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(topScorer);
            LblTopScorer.Text = topScorer.Rows[0][0].ToString() + " " + topScorer.Rows[0][1].ToString() + " (" + topScorer.Rows[0][2].ToString() + ")";
            worstDiscipline = new DataTable();
            sqlQuery = "select p.player_name as `Player`, Kuning.poin + Merah.poin as `Point`, Kuning.Yellow as `Yellow Card`, Merah.Red as `Red Card` from player p, (select dm.player_id as `ID`, sum(if(dm.type = 'CY', 1, 0)) as Yellow, sum(if(dm.type='CY', 1, 0)) as poin from dmatch dm group by 1) `Kuning`, (select dm.player_id as `ID`, sum(if(dm.type = 'CR', 1, 0)) as Red, sum(if(dm.type = 'CR', 3, 0)) as poin from dmatch dm group by 1) `Merah` where p.player_id = Kuning.ID and Kuning.ID = Merah.ID and p.team_id = '" + team.Rows[counter1][3].ToString() + "' order by 2 desc";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(worstDiscipline);
            LblWorstDiscipline.Text = worstDiscipline.Rows[0][0] + ", " + worstDiscipline.Rows[0][2] + " Yellow Card and " + worstDiscipline.Rows[0][3] + " Red Card";
            lastMatch = new DataTable();
            sqlQuery = "select match_date as `match date`, date_format(m.match_date, \"%d/%c/%Y\") as `Match Date`, 'HOME' as `Home/Away`, concat('vs ', t.team_name) as `Lawan`, concat(m.goal_home, ' - ', m.goal_away) as `Score` from `match` m, team t where m.team_home = '" + team.Rows[counter1][3].ToString() + "' and m.team_away = t.team_id union select match_date, date_format(m.match_date, \"%d/%c/%Y\") as `Match Date`, 'AWAY' as 'Home/Away', concat('vs ', t.team_name) as `Lawan`, concat(m.goal_home, ' - ', m.goal_away) as `Score` from `match` m, team t where m.team_away = '" + team.Rows[counter1][3].ToString() + "' and m.team_home = t.team_id order by 1 desc limit 0, 5;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(lastMatch);
            dgvMatch.DataSource = lastMatch;
            dgvMatch.Columns.RemoveAt(0);
        }
    }
}
