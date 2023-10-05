package es.aaronquintanal.primerproyecto;

import java.util.Scanner;
import java.util.logging.LogManager;
import java.util.logging.Logger;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.TypedQuery;

import java.sql.Date;
import java.sql.Time;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.LocalTime;
import java.util.List;

import model.DescargaTotale;
import model.Premium;
import model.Solicitude;
import model.Track;
import model.Usuario;

public class App 
{
	
	private static EntityManagerFactory emf = Persistence.createEntityManagerFactory("PrimerProyecto");
    private static EntityManager em = emf.createEntityManager();
    private static Scanner scanner = new Scanner(System.in);
	
    public static void main( String[] args )
    {
        LogManager.getLogManager().reset();
        Logger globalLogger = Logger.getLogger(java.util.logging.Logger.GLOBAL_LOGGER_NAME);
        globalLogger.setLevel(java.util.logging.Level.INFO);
        
        int opt;
        
        do {
        	System.out.println("\n\n***MENU***");
        	System.out.println("1. Agregar usuario premium.");
        	System.out.println("2. Actualizar datos por finalización descargas.");
        	System.out.println("3. Añadir solicitud.");
        	System.out.println("4. Obtener tracks solicitados por usuario.");
        	System.out.println("5. Obtener usuarios sin descargas.");
        	System.out.println("6. Obtener datos de más descargas.");
        	System.out.println("0. Salir.");
        	
        	opt = scanner.nextInt();
        	
        	switch(opt) {
        		case 1 -> option1();
        		case 2 -> option2();
        		case 3 -> option3();
        		case 4 -> option4();
        		case 5 -> option5();
        		case 6 -> option6();
        		case 0 -> System.out.println("Saliendo...");
        		default -> System.out.println("Opción no recogida");
        	}
        } while(opt != 0);
        
        //Todo lo cierro aqui para no tener que abrir y cerrar la instancia al EntityManager todo el rato
        em.close();
    	emf.close();
    	scanner.close();
    }
    
    private static void option1() {
    	System.out.println("\nAgregaremos un usuario Premium.");
    	
    	Premium premium = new Premium();
    	
    	premium.setNumUsu(20);
    	premium.setApellidos("Quintanal Martin");
    	premium.setContra("1234");
    	premium.setFechanac(Date.valueOf("1996-2-15"));
    	premium.setNombre("Aaron");
    	premium.setUsuario("Aaronibio");
    	premium.setAntiguedad(15);
    	premium.setCuota(15f);
    	
    	em.getTransaction().begin();
    	em.persist(premium);
    	em.getTransaction().commit();
    }
    private static void option2() {
    	listarSolicitudesFinalizadas();
    }
    private static void option3() {
    	System.out.println("\n\nIntroduce los datos de la solicitud por teclado:");
    	System.out.println("\tId de uuario:");
    	Usuario usuario = obtenerUsuario(scanner.nextInt());
    	
    	System.out.println("\tId de audio:");
    	Track track = obtenerTrack(scanner.nextInt());
    	
    	if(usuario != null && track != null) {
    		Solicitude solicitude = new Solicitude();
    		
    		solicitude.setFecha(Date.valueOf(LocalDate.now()));
    		solicitude.setHora(Time.valueOf(LocalTime.now()));
    		solicitude.setTrack(track);
    		solicitude.setUsuarioBean(usuario);
    		
    		em.getTransaction().begin();
    		em.persist(solicitude);
    		em.getTransaction().commit();
    	} else {
    		System.out.println("\n\tEl usuario o el audio no existen.");
    	}
    }
    private static void option4() {
    	System.out.println("Selecciona el usuario para obtener sus audios solicitados:");
    	
    	try {
    		Usuario usuario = em.find(Usuario.class, scanner.nextInt());
    		
    		if(usuario != null) {
    			System.out.println("\n\nSolicitudes de " + usuario.getNombre());
    			
    			TypedQuery<Solicitude> query = em.createQuery("SELECT s FROM Solicitude s WHERE s.usuarioBean = :usu AND s.finalizada = :param", Solicitude.class)
    					.setParameter("usu", usuario)
    					.setParameter("param", false);
    			List<Solicitude> solicitudes = query.getResultList();

				System.out.println("\n\nSolicitudes de " + usuario.getNombre());
				solicitudes.forEach(s -> {
					System.out.println("\tAudio: " + s.getTrack().getTitulo());
				});
    		}
    		
    	} catch(Exception e) {
    		System.out.println("Este usuario no tiene solicitudes.");
    	}
    	
    }
    private static void option5() {
    	System.out.println("Usuarios sin descargas:");
    	
    	TypedQuery<Usuario> query = em.createQuery("SELECT usu FROM Usuario usu WHERE usu.numUsu NOT IN (SELECT DISTINCT u FROM Usuario u RIGHT JOIN DescargaTotale d on d.usuario = u)", Usuario.class);
    	List<Usuario> usuarios = query.getResultList();
    	
    	usuarios.forEach(u -> {
    		System.out.println("\t" + u.getNombre() + " " + u.getApellidos());
    	});
    }
    private static void option6() {
    	System.out.println("Introduce un número para mostrar quién ha descargado más canciones en total que eso:");
    	
    	TypedQuery<DescargaTotale> query = em.createQuery("SELECT d FROM DescargaTotale d WHERE d.total > :param", DescargaTotale.class)
    			.setParameter("param", scanner.nextInt());
    	List<DescargaTotale> descargas = query.getResultList();
    	
    	descargas.forEach(d -> {
    		System.out.println("\n\tUsuario: " + d.getUsuario().getNombre() + " " + d.getUsuario().getApellidos() + "---"  + d.getTrack().getTitulo() + " : " + d.getTotal());
    	});
    } 
    private static Usuario obtenerUsuario(int id) {
    	em.getTransaction().begin();
    	
    	try {
    		Usuario usuario = em.find(Usuario.class, id);
    		
    		if(usuario != null) {
    			return usuario;
    		}
    		
    	} catch(Exception e) {
    		System.out.println(e.getMessage());
    	} finally {
    		em.getTransaction().commit();
    	}
    	
    	return null;
    }
    private static Track obtenerTrack(int id) {
    	em.getTransaction().begin();
    	
    	try {
    		Track track = em.find(Track.class, id);
    		
    		if(track != null) {
    			return track;
    		}
    	} catch(Exception e) {
    		System.out.println(e.getMessage());
    	} finally {
    		em.getTransaction().commit();
    	}
    	
    	return null;
    }
    private static void listarSolicitudesFinalizadas() {
    	TypedQuery<Solicitude> query = em.createQuery("SELECT s FROM Solicitude s WHERE s.finalizada = :param", Solicitude.class)
    	.setParameter("param", true);
    	List<Solicitude> solicitudes = query.getResultList();
    	
    	solicitudes.forEach(s -> {
    		System.out.println("\n\tSolicitud: " + s.getNum());
    		comprobarDescarga(s);
    	});
    }
    private static void comprobarDescarga(Solicitude s) {
    	TypedQuery<DescargaTotale> query = em.createQuery("SELECT d FROM DescargaTotale d WHERE d.usuario = :usu AND d.track = :track", DescargaTotale.class)
    	.setParameter("usu", s.getUsuarioBean())
    	.setParameter("track", s.getTrack());
    	
    	try {
    		DescargaTotale d = query.getSingleResult();
    		
    		em.getTransaction().begin();
    		d.setTotal(d.getTotal()+1);
    		em.getTransaction().commit();
    		
    	} catch(Exception e) {
    		crearDescarga(s);
    	}
    }    
    private static void crearDescarga(Solicitude s) {
    	DescargaTotale d = new DescargaTotale();
    	
    	d.setTrack(s.getTrack());
    	d.setUsuario(s.getUsuarioBean());
    	d.setTotal(0);
    	
    	em.getTransaction().begin();
    	em.persist(d);
    	em.getTransaction().commit();
    }
}
