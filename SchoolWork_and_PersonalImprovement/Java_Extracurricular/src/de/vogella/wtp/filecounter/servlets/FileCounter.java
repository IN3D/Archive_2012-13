package de.vogella.wtp.filecounter.servlets;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import de.vogella.wtp.filecounter.dao.FileDao;

/**
 * Servlet implementation class FileCounter
 */

public class FileCounter extends HttpServlet {
	private static final long serialVersionUID = 1L;
	
	int count;
	private FileDao dao;
	
	public void init() throws ServletException {
		dao = new FileDao();
		try {
			count = dao.getCount();
		} catch (Exception e) {
			getServletContext().log("An exception occurred in FileCounter", e);
			throw new ServletException("An excpetion occurred in FileCounter" + e.getMessage());
		}
	}
       
    /**
     * @see HttpServlet#HttpServlet()
     */
	//Untouched
    public FileCounter() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//Set a cookie for the user, so that the counter does not increase
		//every time the user presses refresh
		HttpSession session = request.getSession(true);
		//Set the session valid for 5 seconds
		session.setMaxInactiveInterval(5);
		response.setContentType("text/plain");
		PrintWriter out = response.getWriter();
		if (session.isNew()) {
			count++;
		}
		out.println("This site has been accessed "+count+" times.");
	}
	
	public void destory() {
		super.destroy();
		try {
			dao.save(count);
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	//Untouched
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}

}
