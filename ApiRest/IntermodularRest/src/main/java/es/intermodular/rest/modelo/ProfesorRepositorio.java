package es.intermodular.rest.modelo;

import java.util.List;
import java.util.Optional;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

public interface ProfesorRepositorio extends JpaRepository<Profesor, Integer> {
    @Query(value = "SELECT p.* FROM profesores p JOIN profesor_tiene_perfil pt ON p.id = pt.profesor WHERE pt.perfil IN (2, 4)", nativeQuery = true)
    List<Profesor> findProfesoresConPerfiles2y4();
}
