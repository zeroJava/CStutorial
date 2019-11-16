using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStutorial.Event
{
	/*
	 * This is an entension of delegates,please
	 * start from DelegateEx1.cs in delegate.
	 * */

	/*
	 * An event behaves as an extension to the
	 * delegates, in the sense that we need to
	 * delagetes to use events; no delegates no
	 * events, i.e. without delegates you won't
	 * be able to create events.
	 * */

	/* 
	 * So what is the purpose of an event?
	 * 
	 * The purpose of an event is to add layer
	 * of safety to delegates, i.e add safety
	 * ristrictions to exposed delegates.
	 * 
	 * */

	public class EventEx1
	{
		public void ExplainDelegateEventSafety()
		{
			/*
			 * The layer of safety that is added
			 * is when the we subscribe a method
			 * to an event.
			 * 
			 * With delegates, you will see that,
			 * we can assign  methods using '-+',
			 * also we can assign method to dele-
			 * gates using '=' operator.
			 * 
			 * With events, assigning a method
			 * using the '=' operator is illegal,
			 * and would throw compilers.
			 * 
			 * */

			/*
			 * Event Accessor.
			 * 
			 * Event accessors are the events 
			 * implementation of the '+=' and '-='
			 * operator which are the add and remove
			 * operators.
			 * 
			 * The compiler actually converts it
			 * ,and add & remove operator behind
			 * the scens similar two properties.
			 * 
			 * The code in event shows example.
			 * 
			 * Compiler also know which version of 
			 * the operators we're using.
			 * */

			EventInnerEx1 d1 = new EventInnerEx1();

			/*
			 * With delegates, you can see we're
			 * assigning the methods, but where
			 * we use '=', it-s actually wiping
			 * everything else, and creating a
			 * new object, with the previous re-
			 * ferences
			 * 
			 * */

			d1.DelegateOne += StringMethodOne;
			d1.DelegateOne = StringMethodTwo;
			d1.DelegateOne += null;
			d1.DelegateOne = null;

			/*
			 * With events, assigning a method
			 * using the '=' operator is illegal,
			 * and would throw compilers.
			 * 
			 * This is becuause, using the '='
			 * will replace all subscribers or
			 * delete all subscribers if null is
			 * used.
			 * */

			d1.EventDelegateTwo += StringMethodOne;
			d1.EventDelegateTwo += StringMethodTwo;
			//d1.EventDelegateTwo = null;

			d1.Execute();

			/*
			 * With delegetes, your able to explictly
			 * call the delegate, but with events that
			 * is not possbile.
			 * */

			d1.DelegateOne("explicty invoke");
			// d1.EventDelegateTwo(""); // Not possible.

			/*
			 * Event modifiers.
			 * Like method you can assign events virtual
			 * overridded, abstract and seal.
			 * */
		}

		private static void StringMethodOne(string name)
		{
			Console.WriteLine("StringMethodOne");
		}

		private static void StringMethodTwo(string name)
		{
			Console.WriteLine("StringMethodTwo");
		}

		private static void StringMethodThree(string name)
		{
			Console.WriteLine("StringMethodThree");
		}
	}

	/*
	 * DotNet (.net) has a standard pattern for
	 * writing event handlers.
	 * 
	 * It must have a:
	 * - void return type.
	 * - expect two argument: object and eventargs.
	 * - must end with EventHandler.
	 * */
	public delegate void EventInnerEx1EventHandler(object sender, EventInnerEx1Arg args);
	public class EventInnerEx1
	{
		public Action<string> DelegateOne;
		public event Action<string> EventDelegateTwo;

		/*
		 * Event Accessor.
		 * 
		 * Event accessors are the events 
		 * implementation of the '+=' and '-='
		 * operator, which are the add and
		 * remove operators.
		 * 
		 * When create a event variable, this
		 * is want happens behine the scene
		 * during compilation.
		 * 
		 * */

		/*
		 * 1)
		 * During compilations if creates a
		 * private delegate variable.
		 * */
		private Action<string> actionDelegate;

		/*
		 * 2)
		 * Create the event variable, with exp-
		 * lictly adding the add and remove
		 * operator during the compilation time.
		 * 
		 * The add operator is the events '+='
		 * The remove operator is the events '-='
		 * 
		 * Note
		 * Behind code, c# added other stuff like
		 * thread safety.
		 * */
		public event Action<string> EventDelegateThree
		{
			add
			{
				actionDelegate += value;
			}
			remove
			{
				actionDelegate -= value;
			}
		}

		public void Execute()
		{
			Console.WriteLine("Delegate");
			if (DelegateOne != null)
			{
				DelegateOne.Invoke("DelOne");
			}
			Console.WriteLine("Event");
			if (EventDelegateTwo != null)
			{
				EventDelegateTwo.Invoke("DelTwo");
			}
		}
	}

	public class EventInnerEx1Arg : EventArgs
	{
		//
	}
}