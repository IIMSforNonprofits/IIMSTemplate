class App extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }
    render() {
        return (
            <div className="App">I am an App container fill me with components.
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

ReactDOM.render(<App />, document.getElementById('content'));
