/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package pe.edu.pucp.projectsoft.DAO;

import java.util.ArrayList;
import pe.edu.pucp.projectsoft.model.Docente;

/**
 *
 * @author gabri
 */
public interface DocenteDAO {
    ArrayList<Docente> listarPorCodigoPUCPNombre(String nombre);
}
