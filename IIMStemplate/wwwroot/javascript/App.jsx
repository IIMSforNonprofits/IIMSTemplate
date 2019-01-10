class App extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }
    render() {
        return (
            <div className="App">I am an App container fill me with components.
                <Navbar /> {/* Ternary operation to show or hide based on login for Landing */}
            </div>
            // browser router component TODO: - react-router-dom (package) (directing to new page layouts ie exact routes and catch all route.)
            /* example router.js file to import routes from: 
                const ROUTES = {
                  LANDING: '/',
                  SIGNUP: '/signup',
                  DASHBOARD: '/dashboard',
                  PRIVACY: '/privacy',
                  PRIVACY_REJECTED: '/privacy-notice-rejected',
                  NOT_FOUND: '/not-found',
                  PREFERENCES: '/preferences',
                  AGENDA: '/agenda',
                };

                export default ROUTES;

                ======================================
                <Route path={ROUTES.LANDING} component={Landing} />
             */
        );
    }
}

////////////////// CONFIRMATION ///////////////////////

class Confirmation extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }
    render() {
        return (
            <div className="Confirmation">I am a Confirmation alert to make sure you want to take this action.
            </div>
            // ?Alert or Modal for this component - functionality is to double check you are sure you are sure you want to take this action
        );
    }
}

////////////////// DASHBOARD ///////////////////////

class Dashboard extends React.Component {
    constructor(props) {
        super(props);
        this.state = {} // possibly cache information from below into state object for faster rendering if revisiting page - cutdown calls to backend
    }                   // based on your policy add the level of access to state use this to render different navbar based on level
    render() {
        return (
            <div className="Dashboard">I am a Dashboard landing page.
            </div>
            // Recent actions - Source is logs - fetch 3 - 5 most recent actions display in a list 
            // ?Receent or Pending orders - Source is Orders - top 3 - 5 orders depends on use case
            // Misc - admin shows pending user approvals - top 3 - 5 oldest --- Hidden for normal users 
        );
    }
}

////////////////// DETAILMETRICS ///////////////////////

class DetailMetrics extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }

    // This is a new standalone page to be rendered since a lot more information on the specific metrics job will be present 
    render() {
        return (
            <div className="DetailMetrics">I am a DetailMetrics view.
            </div>
            // example content is sql query, description, data visualization 
            // ? back button to metrics page or browser back button ?
        );
    }
}

////////////////// DETAILVIEW ///////////////////////

class DetailView extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }
    render() {
        return (
            <div className="DetailView">I am a DetailView Modal.
            </div>
            /* Example of a modal
             * import React from 'react';

                const Modal = (props) => {
                  const showHideClassName = props.show ? "modal display-block" : 'modal display-none';

                  return (
                    <div className={showHideClassName}>
                      <div className="modal-main">
                        <button onClick={props.handleClose}>X</button>
                        {props.children}
                      </div>
                    </div>
                  )
                }

                export default Modal;
             */
        );
    }
}

////////////////// DONORS ///////////////////////

class Donors extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }
    // =======================================
    // Methods 
    // componentDidMount() - async call to db for paginated donors list. Proof of life is full list. 
    // =======================================
    render() {
        return (
            <div className="Donors">I am a Donors landing page.
            </div>
            // Render as a table with clickable table row 
            // ForEach to render the object into the table.
        );
    }
}

////////////////// INVENTORY ///////////////////////

class Inventory extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }
    // =======================================
    // Methods 
    // componentDidMount() - async call to db for paginated inventory list. Proof of life is full list. 
    // =======================================
    render() {
        return (
            <div className="Inventory">I am an Inventory dashboard landing page.
            </div>
            // Render as a table with clickable table row 
            // ForEach to render the object into the table. 
        );
    }
}

////////////////// LANDING ///////////////////////

class Landing extends React.Component {
    constructor(props) {
        super(props);
        this.state = {} // viewSelected = either login as default state or signUp based on viewSwap Method
    }

    // Methods -- 
    // ?componentDidMount -  
    // login - async call to check with identity service - if valid redirect to dashboard component
    // signUp - create user in DB and redirect to the pending page for new users -- add user to identity service
    // viewSwap - button switch between two different views 

    render() {
        return (
            <div className="Landing">I am a signup/sign-in Landing page.
            </div>
            // Displays login by default with a signup button that will change the display feature and allow for sign up
            // Cookies are taken care of already via .net - TODO: check Identity cookie time limit
            // Forgotten password 
            // selecting a role for signUp
        );
    }
}

////////////////// LOGS ///////////////////////

class Logs extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }
    render() {
        return (
            <div className="Logs">I am a Logs landing page.
            </div>
            // Unordered list of clickable links to detail Modal (link will be entire text box), a brief description
            // User - Date - Action taken - resolution ( <<<<<<<<<<< detail view )
        );
    }
}

////////////////// METRICS ///////////////////////

class Metrics extends React.Component {
    constructor(props) {
        super(props);
        this.state = {} // caching of results from initial population of links for faster page load.
    }
    render() {
        return (
            <div className="Metrics">I am a Metrics Dashboard landing page.
            </div>
            // Unordered list of clickable links to detail view(link will be name of query), a brief description 
        );
    }
}

////////////////// NAVBAR ///////////////////////

class Navbar extends React.Component {
    constructor(props) {
        super(props);
        this.state = {} // based on your policy add the level of access to state use this to render different navbar based on level
    }
    render() {
        // Logic that determines which object for policy level to render in the navbar component
        return (
            <div className="Navbar"> {/* Flex box and display as columns for the flexbox css*/}
                <ul id="nav">
                    <li>Dashboard</li> {/* referential links or Link tags for displaying proper components based on navigation*/}
                    <li>Metrics</li>
                    <li>Inventory</li>
                    <li>Orders</li>
                    <li>Logs</li>
                    <li>Donors</li>
                    <li>Users</li>
                </ul>
            </div>
            // <div className=Navbar> <ul> <li>{Dashboard}</li> </ul> </div>
        );
    }
}

////////////////// ORDERs ///////////////////////

class Orders extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }
    // =======================================
    // Methods 
    // componentDidMount() - async call to db for paginated orders list. Proof of life is full list. 
    // =======================================

    render() {
        return (
            <div className="Orders">I am a Orders dashboard landing page.
            </div>
            // Render as a table with clickable table row 
            // ForEach to render the object into the table. 
        );
    }
}

////////////////// PENDING ///////////////////

class Pending extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }
    render() {
        return (
            <div className="Pending">I am a Pending user landing page for users who do not have permissions yet.
            </div>
            // Also needs to handle authorization redirect for unauthorized user.
            // Render a link to documentation for application and "Pending user waiting for approval seek admin"
        );
    }
}

////////////////// USERS ///////////////////////

class Users extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }
    // =======================================
    // Methods 
    // componentDidMount() - async call to db for paginated users list. Proof of life is full list. 
    // =======================================

    render() {
        return (
            <div className="Users">I am a User approval dashboard page.
            </div>
            // Render as a table with clickable table row 
            // ForEach to render the object into the table. 
        );
    }
}

// ////////////////////////////////////////////////////////////////////

ReactDOM.render(<App />, document.getElementById('content'));
