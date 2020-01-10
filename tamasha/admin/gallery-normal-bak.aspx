<%@ Page Title="" Language="C#" MasterPageFile="~/admin/menu.master" AutoEventWireup="true" CodeFile="gallery-normal.aspx.cs" Inherits="admin_gallery_normal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <style>
        .flip-card {
          background-color: transparent;
          /*width: 300px;
          height: 300px;*/
          perspective: 1000px;
            -webkit-perspective: 1000px;
        }

        .flip-card-inner {
          position: relative;
          width: 100%;
          height: 100%;
          text-align: center;
          transition: transform 0.6s;
            -webkit-transition: transform 0.6s;
  
          transform-style: preserve-3d;
            -webkit-transform-style: preserve-3d; /* Safari 4-8 */
          box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
        }

        .flip-card:hover .flip-card-inner {
          transform: rotateY(180deg);
            -ms-transform: rotateY(180deg); /* IE 9 */
                -webkit-transform: rotateY(180deg);
        }

        .flip-card-front, .flip-card-back {
          position: absolute;
          width: 100%;
          height: 100%;
          backface-visibility: hidden;
            -webkit-backface-visibility: hidden;  
        }

        .flip-card-front {
          background-color: #bbb;
          color: black;
          z-index: 2;
        }

        .flip-card-front:hover {
          visibility: hidden;
        }


        .flip-card-back {
          background-color: #2980b9;
          color: white;
          transform: rotateY(180deg);  
            -ms-transform: rotateY(180deg); /* IE 9 */
                -webkit-transform: rotateY(180deg);
          z-index: 1;
          height: 370px;
        }

        /* General */
        .edit-gallery-button {
            background: #B52E31;
            border: none;
            color: #fff;
            padding: 10px 20px;
            font-size: 0.85em;
            border: none;
        }
    </style>
    <!--content-->
<div class="content">
<div class="women_main">
	<!-- start content -->
   <div class="w_content">
		<div class="women">
			<a href="#"><h4>Normal gallery of carpets </h4></a>
			<ul class="w_nav">
						<li>Sort : </li>
		     			<li><a class="active" href="#">Price: low </a></li> |
		     			<li><a href="#">Price: high </a></li> |
		     			<li><a href="#">Arrival </a></li> |
		     			<li><a href="#">Group </a></li> |
		     			<li><a href="#">Clear </a></li> 
		     			<div class="clear"></div>	
		     </ul>
		     <div class="clearfix"></div>	
		</div>
		<!-- grids_of_4 -->
		<div id="addPicHtml" runat="server" class="grids_of_4">
		 <div class="grid1_of_4">
				<div class="content_box"><a href="details.html">
			   	   	 <img src="../images/gallery/1.jpg" class="img-responsive" alt="">
				   	  </a>
				    <h4><a href="details.html"> Carpet type </a></h4>
				     <p>Carpet details</p>
					 <div class="grid_1 simpleCart_shelfItem">
				    
					 <div class="item_add"><span class="item_price"><h6>ONLY $109.00</h6></span></div>
					<div class="item_add">
                        <span class="item_price"><a href="#">EDIT</a></span>
					    <span class="item_price"><a href="#">DELETE</a></span>
					</div>
					 </div>
			   	</div>
			</div>
			<div class="grid1_of_4 flip-card">
				<div class="content_box flip-card-inner">
                    <div class="flip-card-front">
                         <a href="details.html">
			   	   	       <img src="../images/gallery/2.jpg" class="img-responsive" alt="">
				   	     </a>
                     </div>
				     
					 <div class="grid_1 simpleCart_shelfItem flip-card-back">
					      <h1><a href="details.html" style="color: white;"> Carpet Name </a></h1>
				          <p>Description of carpet</p>
                          <h6 style="padding: 10% 0;">Price: $95.00</h6>
                          <a class="edit-gallery-button" href="gallery-normal-details.aspx">EDIT</a>
                    </div>
			   	</div>
			</div>
			<div class="grid1_of_4">
				<div class="content_box"><a href="details.html">
			   	   	 <img src="../images/gallery/3.jpg" class="img-responsive" alt="">
				   	  </a>
				    <h4><a href="details.html"> Duis autem</a></h4>
				     <p>It is a long established fact that</p>
					 <div class="grid_1 simpleCart_shelfItem">
				    
					 <div class="item_add"><span class="item_price"><h6>ONLY $68.00</h6></span></div>
					<div class="item_add"><span class="item_price"><a href="#">add to cart</a></span></div>
					 </div>
			   	</div>
			</div>
			<div class="grid1_of_4">
				<div class="content_box"><a href="details.html">
			   	   	 <img src="../images/gallery/4.jpg" class="img-responsive" alt="">
				   	  </a>
				    <h4><a href="details.html"> Duis autem</a></h4>
				     <p>It is a long established fact that</p>
					 <div class="grid_1 simpleCart_shelfItem">
				    
					 <div class="item_add"><span class="item_price"><h6>ONLY $74.00</h6></span></div>
					<div class="item_add"><span class="item_price"><a href="#">add to cart</a></span></div>
					 </div>
			   	</div>
			</div>
			<div class="clearfix"></div>
		</div>
		
		<div class="grids_of_4">
		  
			
			
			<div class="grid1_of_4" style="margin-left: 2.4%;">
				<div class="content_box"><a>
			   	   	 <img src="../images/gallery/spacer.jpg" class="img-responsive" alt="">
				   	  </a>
				    <h4><a> Halisen Cerpet</a></h4>
				     <p>a milinum in carpet's market</p>
					 <div class="grid_1 simpleCart_shelfItem">
				    
					 <div class="item_add"><span class="item_price"><h6>variety of prices</h6></span></div>
					<div class="item_add"><span class="item_price"></span></div>
					 </div>
			   	</div>
			</div>
			<div class="clearfix"></div>
            <div class="panel panel-widget forms-panel">
						<div class="forms">
							<div class="form-grids widget-shadow" data-example-id="basic-forms"> 
								<div class="form-title">
									<h4>Add to gallery: </h4>
								</div>
								<div class="form-body">
									<div> 
                                        <div class="checkbox"> 
                                            <span>Groups of types: </span><asp:DropDownList ID="ddlGropus" runat="server"></asp:DropDownList>
                                        </div> 
                                        <div class="checkbox"> 
                                            <span>Groups of colors: </span><asp:DropDownList ID="ddlColors" runat="server"></asp:DropDownList>
                                        </div>
                                        <div class="checkbox"> 
                                            <span>Groups of shapes: </span><asp:DropDownList ID="ddlShape" runat="server"></asp:DropDownList>
                                        </div>
                                        <div class="checkbox"> 
                                            <span>Groups of size: </span><asp:DropDownList ID="ddlSize" runat="server"></asp:DropDownList>
                                        </div>
                                        <hr />
                                        <div class="form-group"> 
                                            <label for="exampleInputEmail1">Picture Title: </label> 
                                            <asp:TextBox ID="txtTitle" class="form-control" runat="server" placeholder="Eg. Hoze Design"></asp:TextBox>
                                        </div>
                                        <div class="form-group"> 
                                            <label for="exampleInputPassword1">Picture Details: </label>
                                            <asp:TextBox ID="txtDetails" class="form-control" runat="server" placeholder="Eg. a short description of item" TextMode="MultiLine"></asp:TextBox>
                                        </div>
                                        <div class="form-group" style="width: 26%;line-height: 34px;"> 
                                            <label for="exampleInputPassword1" style="float: left;">Item Price: </label>
                                            <asp:TextBox ID="txtPrice" class="form-control" runat="server" placeholder="Eg. 1200" style="width: 70%;float: left;margin-right: 5px;"></asp:TextBox> $ 
                                        </div>
                                        <div class="form-group">
                                            <fieldset class="div_top">
                                                    <legend>File input</legend>
                                                    <asp:FileUpload ID="fuGallery" runat="server" style="margin: 3%"/>
                                            </fieldset>
                                            <p class="help-block">Please choose one picture of item</p> 
                                        </div> 
                                        <asp:Label ID="lblError" runat="server" Text="" Visible="false" ForeColor="#B52E31"></asp:Label>
                                        <asp:Button ID="btnAdd" runat="server" class="btn btn-default" Text="ADD ITEM" OnClick="btnAdd_Click" />
									</div> 
								</div>
							</div>
						</div>
					</div>
		</div>
		
		
		
		
		<!-- end grids_of_4 -->
		
		
	</div>
   <div class="clearfix"></div>
	<!-- end content -->
    </div>
</asp:Content>

