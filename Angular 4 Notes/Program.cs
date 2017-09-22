using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular_4_Notes
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

/*

                    ***** ANGULAR 4 DOCS v.1.0*****


1. Angular 4 
	
  ---> TypeScript-based open-source front-end web application platform.
 
  ---> On 13 December 2016 Angular 4 was announced, skipping 3 to avoid a confusion due to the misalignment of the router package's version which was already distributed as v3.3.0.
       The final version was released on March 23, 2017. Angular 4 is backward compatible with Angular 2.

  ---> Google has adapted SEMVER (Semantic versioning) approach for it’s Angular Framework.

  ---> Angular team has laid emphasis on making angular apps more faster,compact in Angular 4.

  ---> New changes reduce the size of the generated code for your components by around 60% in most cases.

  ---> The more complex your templates are, the higher the savings.

  ---> Faster Compilation

  ---> Better Bug fixes Alert.

  ---> Animations being pulled out of @angular/core so as to remove the extra code being imported into our production bundle.
       Though you can easliy add animation by importing { BrowserAnimationsModule}
from @angular/platform-browser/animations
into NgModule.
 
  ---> Renderer 2 in place of Renderer from same ‘@angular/core’.

  ---> * ngIf/else : Now you can use else clause as well.

  ---> TypeScript 2.1 and 2.2 compatibility: Finally We can use typescript 2.1 or more earlier only upto typescript 1.8 
       was supported.

  ---> ModuleID Removed: They have added a new SystemJS plugin which dynamically converts "component-relative" paths in
       templateUrl and styleUrls to "absolute paths" for you.

  ---> Ahead of Time Compilation - View Engine: As you may know, in AoT mode, Angular compiles your templates during the
       build, and generates JS code whereas in case of Just in Time mode, this compilation is done at runtime.Now, AoT has
       several advantages, like you will get to know that your templates is incorrect at build time instead of having to wait
       at runtime, and the application starts faster (as the code generation is already done). 

  ---> Template is now ng-template.

  ---> Pipes: Angular 4 introduced a new titlecase pipe. It changes the first letter of each word into uppercase:
	
		<p>{ { 'foo bar' | titlecase } }</p>
		  <!-- will display 'Foo Bar' -->

  ---> Http: Adding search parameters to an HTTP request has been simplified:

		http.get(`${ baseUrl}/ api / movies`, {params: { sort: 'ascending'} });


--->Router: A new interface has been introduced to represent the parameters of a URL: ParamMap.

        const id = this.route.snapshot.paramMap.get('xyz');
        this.abcService.get(id).subscribe(abc => this.xyz = xyz);


2. Angular CLI(Command Line Interface)	
	
  ---> Angular CLI is a Command Line Interface(CLI) to automate your development workflow.
  
  ---> Angular CLI allows you to :-
	
	> Create a new Angular Application.
        > Run a development server with LiveReload support to preview your application during development.
	> Add features to your existing Angular application.
	> Run your application’s unit tests.
	> Run your application’s end-to-end (E2E) tests.
	> Build your application for deployment to production.
 
  ---> Angular CLI is a great tool to create and work with Angular Applications .
       It takes away all the pain staking work one has to do otherwise manually by making all the configuration files required
       for bootstrapping an angular application. With few commands it becomes easier to build working components, Services, 
       directives etc.
	
  ---> CLI is shipped with WebPack which bundles javascript and css files dynamically and add them to index. html like
       main.bundle.js , polyfill.bundle. js etc. 


3. Angular 4 Architecture

  ---> There are basically 8 building blocks of Angular 4:-
 
	> MODULES 
		
	---> A module is a mechanism to group components, directives, pipes and services that are related, 
	     in such a way that can be combined with other modules to create an application.

	--->  A module can export or hide components, directives, pipes and services.

	--->  The exported elements are meant to be used by other modules, while the ones that are not exported 
	      (hidden) are just used inside the module itself and cannot be directly accessed by other modules
              of our application.

	---> To be able to define modules we have to use the decorator NgModule.
		..> Decorators are functions that modify JavaScript classes. Angular has many decorators that attach
            metadata to classes so that it knows what those classes mean and how they should work.

				 import { NgModule }
from '@angular/core';

@NgModule
					({

    imports: [ ... ],
 				 declarations: [ ... ],
  				 bootstrap: [ ... ]

                     })
				 
				 export class AppModule { }


	---> The NgModule decorator requires at least three properties: imports, declarations and bootstrap.

        ..> The property imports expects an array of modules.Here's where we define the pieces of 
		    our puzzle (our application).

		..> The property declarations expects an array of components, directives and pipes that are
            part of the module.

        ..> The bootstrap property is where we define the root component of our module.Even though
            this property is also an array, 99% of the time we are going to define only one component.



            Ex. --> 
                    @NgModule({
    imports: [BrowserModule],   --> The BrowserModule is a built -in module that exports
                   basic directives, pipes and services.
    declarations: [AppComponent],
 					bootstrap: [AppComponent]
						})

	--->  There are two types of modules, root modules and feature modules.
         ..> In an application we only have one root module and zero or many feature modules.

         ..>  If the module is importing the BrowserModule then it's a root module, 
		      if instead is importing the CommonModule then it is a feature module.

         ..> As developers, we need to take care of importing the BrowserModule in the root module and instead,
             import the CommonModule in any other module we create for the same application.
 
	
	 > ANGULAR LIBRARIES

	  ---> Angular ships as a collection of JavaScript modules.You can think of them as library modules.

	  ---> Each Angular library name begins with the @angular prefix.

                  Ex. --> 
                    import { BrowserModule }
from '@angular/platform-browser';

					imports: [BrowserModule]

	> COMPONENTS 
	
         ---> A component controls a patch of screen called a view.

	 ---> A component is basically a class that is used to show an element on the screen.
          The components have some properties and by using them we can manipulate how the
          element should look on the screen and behave.

	 ---> We can create a component, destroy and update as the user moves in the application.

	 ---> The view of the component is defined through templates.
          Templates are basically the HTML we use,, to show on our page.

	 
	> METADATA
	
	 ---> Metadata tells angular how a class should be processed on the screen.

	 ---> In TypeScript, you attach metadata by using a decorator.

            Ex. -->

                    @Component({
    selector: 'hero-list',
 					 templateUrl: './hero-list.component.html',
  				 	 providers:  [HeroService]
                        })

					export class HeroListComponent implements OnInit
{
   
} 

	 ---> @Component decorator, which identifies the class immediately below it as a component class.

	 ---> The metadata in the @Component tells Angular where to get the major building blocks you specify 
	      for the component.

	 ---> The template, metadata, and component together describe a view.

	 ---> The architectural takeaway is that you must add metadata to your code so that Angular knows what to do.


	 > DATA BINDING

	 ---> Angular supports data binding, a mechanism for coordinating parts of a template with parts of a component.

	 ---> Data binding is also important for communication between parent and child components.

	 ---> Data Binding Syntax has four forms :- 


          i).	DOM<---------- COMPONENT (To the DOM)

			--> {{value}} (Interpolation)

			    Ex. <li>{{hero.name}}</li>

				{{hero.name}} -> Interpolation displays the component's hero.name property value within
						 the li element.

          ii).  DOM<---------- COMPONENT (To the DOM)

			--> [property] = "value" (Property Binding)

			     Ex. <hero-detail[hero]="selectedHero"></hero-detail>
				
				 [hero] -> Property Binding passes the value of selectedHero from
                       from the parent HeroListComponent to the hero property
                       of the child HeroDetailComponent.

              iii). DOM -----------> COMPONENT(From the DOM)

			--> (event) = "handler" (Event Binding)

			     Ex. <li (click)="selectHero(hero)"></li> 

				 (click) -> Event Binding calls the component's selectHero method when the user 
  				            clicks a hero's name.

		  iv). DOM <-----------> COMPONENT (2 way Binding)
		
			--> <input[(ngModel)]="hero.name">

			    > In two-way binding, a data property value flows to the input box from the component 
			      as with property binding. The user's changes also flow back to the component, 
			      resetting the property to the latest value, as with event binding.


	 > DIRECTIVES	

	   ---> Angular templates are dynamic. When Angular renders them, it transforms the DOM according
        to the instructions given by directives.
	
	   ---> Directive helps us to add behavior to the DOM elements.

       --->In TypeScript we define decoratives by @decorative decorator.

      --->There are 3 types of decorative

          ->Directive - with - a - template
          ->Structural
          ->Attribute

                 >> A component is a directive - with - a - template(Directive - with - a - template)

                 >> Structural directives add, delete and replace DOM elements. 

                Ex.     < li * ngFor = "let food of foods”></li>

                    < food - detail * ngIf = "selectedFood" ></ food - detail >

                   >> Attribute directives changes the appearance of DOM elements.

                Ex.     < input[(ngModel)] = "hero.name" >











    