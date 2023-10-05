package es.intermodular.rest.modelo;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface AvisosRepositorio extends JpaRepository<Aviso_guardia, Integer> {

}