package AD_Hoja_2_02;

import java.sql.*;
import java.time.LocalDate;

public class Ex1 {
    public static void main(String[] args) {

        try {
            Connection connection = DriverManager.getConnection("jdbc:mysql://10.0.13.100:3306/preguntastest?"+
                    "user=aaronq&password=aaronq&allowPublicKeyRetrieval=true&useSSL=false&"+
                    "useUnicode=true&serverTimezone=UTC");


            String sql = "INSERT INTO usuarios (usuario,password,nombre,apellidos,fechanac,num_accesos,test_realizados,puntuacion_media) VALUES (?,md5(?),?,?,?,?,?,?)";
            PreparedStatement preparedStatement = connection.prepareStatement(sql);

            Usuario user = new Usuario("aaron","mysql","Aaron","Quintanal Martin", LocalDate.of(1996,2,15),0,0,10f);

            preparedStatement.setString(1, user.getUsuario());
            preparedStatement.setString(2, user.getPswd());
            preparedStatement.setString(3, user.getNombre());
            preparedStatement.setString(4, user.getApellidos());
            preparedStatement.setDate(5, Date.valueOf(user.getFechanac()));
            preparedStatement.setInt(6, user.getNum_accesos());
            preparedStatement.setInt(7, user.getTest_realizados());
            preparedStatement.setFloat(8, user.getPuntuacion_media());

            preparedStatement.executeUpdate();

        } catch (SQLException e) {
            throw new RuntimeException(e);
        }

    }
}
