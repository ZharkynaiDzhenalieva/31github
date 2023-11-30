<%@ page import="com.example.pizzaorderapp.Model.Pizza" %>
<%@ page import="java.util.ArrayList" %>
<%@ page import="com.example.pizzaorderapp.Model.Topping" %><%--
  Created by IntelliJ IDEA.
  User: hallgato
  Date: 2023. 11. 30.
  Time: 18:27
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
if(request.getParameter("size") != null){
    int size = Integer.parseInt(request.getParameter("size"));
    Pizza myPizza = new Pizza(size);
    session.setAttribute("pizza", myPizza); //attach an attrib to a session
    if(getServletContext().getAttribute("availableToppings") == null){
        ArrayList<Topping> toppings = new ArrayList<>();
        toppings.add(new Topping("Tomatoes", 150));
        toppings.add(new Topping("Cheddar", 300));
        toppings.add(new Topping("Corn", 100));
        toppings.add(new Topping("Mozzarella", 250));
        toppings.add(new Topping("Pineapple", 150));
        toppings.add(new Topping("Broccoli", 200));

        getServletContext().setAttribute("availableToppings", toppings);
    }
}
Pizza aPizza = (Pizza)session.getAttribute("pizza");
ArrayList<Topping> availableToppings = (ArrayList<Topping>)getServletContext().getAttribute("availableToppings");


%>

<h2>Available Toppings, please select the toppings:</h2>
<table border="2">
    <% for(Topping t:availableToppings){%>
    <tr>
        <td><%=t.getName()%></td>
        <td><%=t.getPrice()%>HUF</td>
        <td><a href="ManageServlet?add=<%=t.getName()%>">Add</a></td>
    </tr>
  <% } %>

</table>

<% if(request.getAttribute("message") != null) {%>
<h2><%=request.getAttribute("message")%></h2>
<% } %>

<h2>Total price = <%=aPizza.calculatePrice()%>HUF</h2>

</body>
</html>
